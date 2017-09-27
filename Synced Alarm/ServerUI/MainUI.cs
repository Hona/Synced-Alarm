using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AlarmLibrary;

namespace ServerUI
{
    public partial class MainUI : Form
    {
        private readonly Settings _s;
        private readonly bool _settingsSaveable;

        public MainUI()
        {
            //Initializes variables
            InitializeComponent();
            _s = new Settings();

            //Disables tabs and controls
            btnPostClient.Enabled = false;
            btnAddIntervalTimes.Enabled = false;
            btnAddSpecificAlarm.Enabled = false;

            //Tries to load settings from the file
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\settings.txt"))
                    _s.LoadSettingsFromFile();
                _settingsSaveable = true;
            }
            catch (Exception)
            {
                _settingsSaveable = false;
                var result =
                    MessageBox.Show(
                        $@"Settings file could not be loaded. Create a new configuration?{
                                Environment.NewLine
                            }(Corrupt settings file will be backed up.)",
                        @"Settings couldn't be loaded", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Abort:
                        Close();
                        break;
                    case DialogResult.Yes:
                        File.Copy(Environment.CurrentDirectory + "\\settings.txt",
                            Environment.CurrentDirectory + "\\settings.txt.backup", true);
                        _s = new Settings();
                        break;
                    case DialogResult.No:
                        Close();
                        break;
                }
            }
            UpdateControlValues();
        }

        private void UpdateControlValues()
        {
            //Sets values of controls to setting values
            try
            {
                dtpStartTime.Value = _s.StartTime;
                dtpStopTime.Value = _s.StopTime;
                cbAddAlarmAtStartTime.Checked = _s.AlarmAtStartTime;
                nudAlarmInterval.Value = _s.MinutesInterval;
                if (_s.AlarmList.Count != 0)
                    btnPostClient.Enabled = true;
            }
            catch
            {
                //Ignored
            }
        }

        private void btnPostClient_Click(object sender, EventArgs e)
        {
            //Creates a config manager for the client program
            var config =
                ConfigurationManager.OpenExeConfiguration(Environment.CurrentDirectory + "\\ClientUI.exe");

            //If the Alarms key already exists delete it
            if (config.AppSettings.Settings.AllKeys.Contains("Alarms"))
                config.AppSettings.Settings.Remove("Alarms");

            //Creates and formats a string with the alarms, then writes it the the config file
            var alarmList = "";
            foreach (var alarm in _s.AlarmList)
                alarmList += alarm + ";";
            config.AppSettings.Settings.Add("Alarms", alarmList);
            config.Save(ConfigurationSaveMode.Modified);

            //User selects a folder for the client to be posted to, then copies the files there
            using (var folderSelectorDialog =
                new FolderBrowserDialog {Description = @"Select the destination folder for the client exe."})
            {
                var result = folderSelectorDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderSelectorDialog.SelectedPath))
                {
                    File.Copy(Environment.CurrentDirectory + "\\ClientUI.exe",
                        folderSelectorDialog.SelectedPath + "\\ClientUI.exe", true);
                    File.Copy(Environment.CurrentDirectory + "\\ClientUI.exe.config",
                        folderSelectorDialog.SelectedPath + "\\ClientUI.exe.config", true);
                    File.Copy(Environment.CurrentDirectory + "\\AlarmLibrary.dll",
                        folderSelectorDialog.SelectedPath + "\\AlarmLibrary.dll", true);
                    MessageBox.Show(@"The client app is now configured to use the set alarms.");
                }
                else
                {
                    if (result == DialogResult.Cancel || result == DialogResult.Abort)
                        MessageBox.Show(@"Files were not copied.");
                    if (result == DialogResult.OK)
                        MessageBox.Show(@"The selected path is invalid.");
                }
            }
        }

        private void btnAddIntervalTimes_Click(object sender, EventArgs e)
        {
            //Sets the variables to specified values - the settings class automatically adds the values when ready.
            _s.SetStartTime(dtpStartTime.Value);
            _s.SetStopTime(dtpStopTime.Value);
            _s.SetMinutesInterval(Convert.ToInt32(nudAlarmInterval.Value));
            _s.SetAlarmAtStartTime(cbAddAlarmAtStartTime.Checked);
            if (_s.AlarmList.Count != 0)
                btnPostClient.Enabled = true;
        }

        private void tabSettings_Click(object sender, EventArgs e)
        {
            //Clears the list
            lvAlarmsList.Items.Clear();

            //Iterates through alarms
            foreach (var alarm in _s.AlarmList)
            {
                //Creates a listview item with the values of the alarm
                var lvItem = new ListViewItem(new[]
                {
                    //Collumn string values
                    alarm.AlarmTime.To24HourDateTimeString(), alarm.GetAlarmModeString(), alarm.GetSoundString(),
                    alarm.Message
                })
                {
                    //ListViewItem changes
                    //Checks if the alarm is enabled and sets the checkbox value accordingly
                    Checked = alarm.Enabled
                };

                //Adds the new list item to the listview
                lvAlarmsList.Items.Add(lvItem);
            }
        }

        private void nudIntervalBasedAlarm_ValueChanged(object sender, EventArgs e)
        {
            //Checks whether the interval times are valid
            if (nudAlarmInterval.Value != 0 && dtpStopTime.Value > dtpStartTime.Value)
                btnAddIntervalTimes.Enabled = true;
            else
                btnAddIntervalTimes.Enabled = false;
        }

        private void lvAlarmsList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Finds the alarm selected from the listview and sets the enabled boolean to the checkbox value
            if (_s.FindAlarm(lvAlarmsList.Items[e.Index].SubItems[0].Text.ToDateTimeFrom24HourString(),
                lvAlarmsList.Items[e.Index].SubItems[1].Text.GetAlarmModeFromString(),
                lvAlarmsList.Items[e.Index].SubItems[2].Text.GetSoundFromString(),
                lvAlarmsList.Items[e.Index].SubItems[3].Text, out Alarm selectedAlarm))
                selectedAlarm.Enabled = e.NewValue == CheckState.Checked;
        }

        private void MainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Checks if the settings are fine to be saved, then saves them to a file
            if (_settingsSaveable)
                _s.SaveSettingsToFile();
        }

        private void SpecificControls_Changed(object sender, EventArgs e)
        {
            //Checks whether the alarm is ready to add and changes the enabled boolean on the button
            if (rbSound.Checked || rbTextToSpeech.Checked)
                btnAddSpecificAlarm.Enabled = true;
        }

        private void btnAddSpecificAlarm_Click(object sender, EventArgs e)
        {
            //Creates and adds the specific alarm to the alarm list
            var mode = rbSound.Checked ? AlarmMode.Sound : AlarmMode.TextToSpeech;
            var tempAlarm = new Alarm(mode, dtpSpecificAlarm.Value, false);
            tempAlarm.SetMessage(txtSpecificMessage.Text);
            _s.AddAlarm(tempAlarm);
        }
    }
}