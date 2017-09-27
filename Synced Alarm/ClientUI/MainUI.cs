using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;
using AlarmLibrary;

namespace ClientUI
{
    public partial class MainUI : Form
    {
        private List<Alarm> _alarmsList;

        public MainUI()
        {
            InitializeComponent();
            _alarmsList = new List<Alarm>();

            //Stops the panel flickering - Credit: https://stackoverflow.com/questions/8046560/how-to-stop-flickering-c-sharp-winforms
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, MainPanel, new object[] {true});

            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var alarmStrings = config.AppSettings.Settings["Alarms"].Value.Split(';');
                foreach (var alarmString in alarmStrings)
                    if (!string.IsNullOrWhiteSpace(alarmString))
                    {
                        var a = alarmString.GetAlarmFromString();
                        _alarmsList.Add(a);
                    }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error loading alarms from file");
            }
            UpdateTimer.Interval = 50;
            MainPanel.BackColor = Color.FromArgb(255, 0, 0);

            UpdateAlarmsList();
            UpdateTimer.Start();
        }

        public void UpdateAlarmsList()
        {
            var forAlarmsList = "Remaining Alarms:" + Environment.NewLine + Environment.NewLine;
            forAlarmsList = _alarmsList.Where(alarm => alarm.AlarmTriggered == false).Aggregate(forAlarmsList,
                (current, alarm) => current + alarm.AlarmTime.ToLongTimeString() + Environment.NewLine);
            if (forAlarmsList == "Remaining Alarms:" + Environment.NewLine + Environment.NewLine)
            {
                lblAlarmList.Text = "";
            }
            else
            {
                forAlarmsList = forAlarmsList.Trim();
                lblAlarmList.Text = forAlarmsList;
            }
        }

        private void TriggerAlarms()
        {
            foreach (var alarm in _alarmsList)
                if (DateTime.Now >= alarm.AlarmTime && alarm.AlarmTriggered == false)
                {
                    // Start a thread that calls a parameterized static method.
                    var soundThread = new Thread(SoundAlarm);
                    soundThread.Start(alarm);
                    alarm.AlarmTriggered = true;
                }
        }

        // TODO: Implement the actual sounds
        public static void SoundAlarm(object alarm)
        {
            if (!(alarm is Alarm convertedAlarm)) return;
            switch (convertedAlarm.Sound)
            {
                case Sounds.AnalogWatch:
                    for (var i = 0; i < 6; i++)
                    {
                        Console.Beep(440, 200);
                        Thread.Sleep(200);
                    }
                    break;
                case Sounds.AnnoyingAlarm:
                    for (var i = 0; i < 10; i++)
                    {
                        Console.Beep(880, 100);
                        Thread.Sleep(50);
                    }
                    break;
                case Sounds.SchoolBell:
                    for (var i = 0; i < 20; i++)
                    {
                        Console.Beep(880, 50);
                        Thread.Sleep(10);
                    }
                    break;
                case Sounds.TextToSpeech:
                    var ss = new SpeechSynthesizer();
                    ss.Speak(convertedAlarm.Message);
                    break;
                default:
                    throw new Exception("Different sound enum: " + convertedAlarm.Sound);
            }
        }


        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            TriggerAlarms();
            ChangeColor();
            UpdateTimeUntilNextAlarm();
            UpdateAlarmsList();
        }

        private void UpdateTimeUntilNextAlarm()
        {
            _alarmsList = _alarmsList.OrderBy(x => x.AlarmTime).ToList();
            try
            {
                var timeUntil = _alarmsList.Find(alarm => alarm.AlarmTriggered == false).AlarmTime - DateTime.Now;
                lblTimeUntilNextAlarm.Text =
                    $@"Next alarm in:{Environment.NewLine + timeUntil.Minutes}:{timeUntil.Seconds}";
            }
            catch (Exception)
            {
                lblTimeUntilNextAlarm.Text = @"No more alarms.";
            }
        }

        private void ChangeColor()
        {
            //Colour starts at 255 red

            //Add green
            if (MainPanel.BackColor.R == 255 && MainPanel.BackColor.G < 255 && MainPanel.BackColor.B == 0)
                MainPanel.BackColor = Color.FromArgb(MainPanel.BackColor.R, MainPanel.BackColor.G + 3,
                    MainPanel.BackColor.B);
            //Remove Red
            if (MainPanel.BackColor.R > 0 && MainPanel.BackColor.G == 255 && MainPanel.BackColor.B == 0)
                MainPanel.BackColor = Color.FromArgb(MainPanel.BackColor.R - 3, MainPanel.BackColor.G,
                    MainPanel.BackColor.B);
            //Add blue
            if (MainPanel.BackColor.R == 0 && MainPanel.BackColor.G == 255 && MainPanel.BackColor.B < 255)
                MainPanel.BackColor = Color.FromArgb(MainPanel.BackColor.R, MainPanel.BackColor.G,
                    MainPanel.BackColor.B + 3);
            //Remove Green
            if (MainPanel.BackColor.R == 0 && MainPanel.BackColor.G > 0 && MainPanel.BackColor.B == 255)
                MainPanel.BackColor = Color.FromArgb(MainPanel.BackColor.R, MainPanel.BackColor.G - 3,
                    MainPanel.BackColor.B);
            //Add red
            if (MainPanel.BackColor.R < 255 && MainPanel.BackColor.G == 0 && MainPanel.BackColor.B == 255)
                MainPanel.BackColor = Color.FromArgb(MainPanel.BackColor.R + 3, MainPanel.BackColor.G,
                    MainPanel.BackColor.B);
            //Remove blue
            if (MainPanel.BackColor.R == 255 && MainPanel.BackColor.G == 0 && MainPanel.BackColor.B > 0)
                MainPanel.BackColor = Color.FromArgb(MainPanel.BackColor.R, MainPanel.BackColor.G,
                    MainPanel.BackColor.B - 3);
        }

        private void MainUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.F11) return;
            switch (WindowState)
            {
                case FormWindowState.Normal:
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                    Bounds = Screen.PrimaryScreen.Bounds;
                    TopMost = true;
                    break;
                case FormWindowState.Maximized:
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;
                    Bounds = new Rectangle(0, 0, 775, 434);
                    CenterToScreen();
                    TopMost = false;
                    break;
            }
        }
    }
}