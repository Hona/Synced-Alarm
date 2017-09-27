using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AlarmLibrary;

namespace ServerUI
{
    public class Settings
    {
        #region IntializedBooleans

        //Booleans for checking whether intervals are ready to be added
        private bool _isIntervalSet;

        private bool _isStartTimeSet;
        private bool _isStopTimeSet;
        private bool _isDefaultSoundSet;

        #endregion

        #region Properties

        //TimeOffset is an offset from servers time - offset added to now at settings save
        public int MinutesOffset { get; set; }

        //Intervals between alarms
        public int MinutesInterval { get; private set; }

        //Time interval alarms start
        public DateTime StartTime { get; private set; }

        //Time interval alarms stop
        public DateTime StopTime { get; private set; }

        //Default sound to play
        public Sounds DefaultSound { get; private set; }

        //List of alarms
        public List<Alarm> AlarmList { get; private set; }

        //Chooses whether an alarm is added at the start time of the interval alarms
        public bool AlarmAtStartTime { get; private set; }

        // The default TextToSpeech message.
        public string DefaultTextToSpeechMessage { get; private set; }

        #endregion

        #region Constructors

        public Settings()
        {
            InitializeLists();
        }

        public Settings(DateTime startTime, DateTime stopTime, int minutesInterval)
        {
            InitializeLists();

            SetStartTime(startTime);
            SetStopTime(stopTime);
            SetMinutesInterval(minutesInterval);
        }

        public Settings(DateTime startTime, DateTime stopTime, int minutesInterval, bool setAlarmAtStart)
        {
            InitializeLists();

            SetStartTime(startTime);
            SetStopTime(stopTime);
            SetMinutesInterval(minutesInterval);
            SetAlarmAtStartTime(setAlarmAtStart);
        }

        public Settings(DateTime startTime, DateTime stopTime, int minutesInterval, Sounds defaultSound)
        {
            InitializeLists();

            SetStartTime(startTime);
            SetStopTime(stopTime);
            SetMinutesInterval(minutesInterval);
            SetDefaultSound(defaultSound);
        }

        public Settings(DateTime startTime, DateTime stopTime, int minutesInterval, Sounds defaultSound,
            bool setAlarmAtStart)
        {
            InitializeLists();

            SetStartTime(startTime);
            SetStopTime(stopTime);
            SetMinutesInterval(minutesInterval);
            SetDefaultSound(defaultSound);
            SetAlarmAtStartTime(setAlarmAtStart);
        }

        #endregion

        #region Methods

        public void SaveSettingsToFile()
        {
            //Deletes the current settings file
            if (File.Exists(Environment.CurrentDirectory + "\\settings.txt"))
                File.Delete(Environment.CurrentDirectory + "\\settings.txt");
            using (var fs = new FileStream(Environment.CurrentDirectory + "\\settings.txt", FileMode.CreateNew))
            {
                //Writes all settings to the file
                var toWrite = Encoding.ASCII.GetBytes($"#MinutesOffset={MinutesOffset + Environment.NewLine}");
                fs.Write(toWrite, 0, toWrite.Length);

                toWrite = Encoding.ASCII.GetBytes($"#MinutesInterval={MinutesInterval + Environment.NewLine}");
                fs.Write(toWrite, 0, toWrite.Length);

                toWrite = Encoding.ASCII.GetBytes(
                    $"#StartTime={StartTime.To24HourDateTimeString() + Environment.NewLine}");
                fs.Write(toWrite, 0, toWrite.Length);

                toWrite = Encoding.ASCII.GetBytes(
                    $"#StopTime={StopTime.To24HourDateTimeString() + Environment.NewLine}");
                fs.Write(toWrite, 0, toWrite.Length);

                toWrite = Encoding.ASCII.GetBytes($"#DefaultSound={DefaultSound + Environment.NewLine}");
                fs.Write(toWrite, 0, toWrite.Length);

                toWrite = Encoding.ASCII.GetBytes("$AlarmList" + Environment.NewLine);
                fs.Write(toWrite, 0, toWrite.Length);

                toWrite = Encoding.ASCII.GetBytes(
                    $"//Format: Enabled,AlarmTime,Message,Sound,AlarmMode,PartOfIntervalSet{Environment.NewLine}");
                fs.Write(toWrite, 0, toWrite.Length);

                var tempAlarmsList = "";
                foreach (var alarm in AlarmList)
                    tempAlarmsList += $"%{alarm + Environment.NewLine}";
                tempAlarmsList += "$EndAlarmList" + Environment.NewLine;

                toWrite = Encoding.ASCII.GetBytes(tempAlarmsList);
                fs.Write(toWrite, 0, toWrite.Length);

                toWrite = Encoding.ASCII.GetBytes($"#AlarmAtStartTime={AlarmAtStartTime + Environment.NewLine}");
                fs.Write(toWrite, 0, toWrite.Length);

                toWrite = Encoding.ASCII.GetBytes(
                    $"#DefaultTextToSpeechMessage={DefaultTextToSpeechMessage + Environment.NewLine}");
                fs.Write(toWrite, 0, toWrite.Length);
                //Closes filestream
            }
        }

        public void LoadSettingsFromFile()
        {
            //Opens the settings file as a string array
            var settingStrings = File.ReadAllLines(Environment.CurrentDirectory + "\\settings.txt");
            //Iterates through the array adding the settings
            if (settingStrings.Length >= 1)
                foreach (var settingString in settingStrings)
                    if (!string.IsNullOrEmpty(settingString))
                    {
                        if (settingString[0] == '#')
                        {
                            if (settingString.Contains("#MinutesOffset"))
                                if (settingString.Split('=')[1] != string.Empty)
                                    MinutesOffset = Convert.ToInt32(new string(settingString.Split('=')[1]
                                        .Where(char.IsNumber).ToArray()));
                            if (settingString.Contains("#MinutesInterval"))
                                if (settingString.Split('=')[1] != string.Empty)
                                    MinutesInterval = Convert.ToInt32(new string(settingString.Split('=')[1]
                                        .Where(char.IsNumber).ToArray()));
                            if (settingString.Contains("#StartTime"))
                                if (settingString.Split('=')[1] != string.Empty)
                                    StartTime = settingString.Split('=')[1].ToDateTimeFrom24HourString();
                            if (settingString.Contains("#StopTime"))
                                if (settingString.Split('=')[1] != string.Empty)
                                    StopTime = settingString.Split('=')[1].ToDateTimeFrom24HourString();
                            if (settingString.Contains("#DefaultSound"))
                                if (settingString.Split('=')[1] != string.Empty)
                                    DefaultSound = settingString.Split('=')[1].GetSoundFromString();
                            if (settingString.Contains("#AlarmAtStartTime"))
                                if (settingString.Split('=')[1] != string.Empty)
                                    AlarmAtStartTime =
                                        Convert.ToBoolean(Convert.ToString(new string(settingString.Split('=')[1]
                                            .Where(char.IsLetter).ToArray())));
                            if (settingString.Contains("#DefaultTextToSpeechMessage"))
                                if (settingString.Split('=')[1] != string.Empty)
                                    DefaultTextToSpeechMessage = settingString.Split('=')[1];
                        }
                        if (settingString[0] == '%')
                            if (!string.IsNullOrEmpty(settingString.Split('%')[1]))
                                AlarmList.Add(settingString.Split('%')[1].GetAlarmFromString());
                    }
        }

        private void InitializeLists()
        {
            //Creates instance of the alarm list
            AlarmList = new List<Alarm>();
        }

        public bool IsInitialized()
        {
            return _isDefaultSoundSet && _isIntervalSet && _isStartTimeSet && _isStopTimeSet &&
                   AlarmList.Count != 0;
        }

        public void SetAlarmAtStartTime(bool doAlarm)
        {
            AlarmAtStartTime = doAlarm;
            TryAddIntervals();
        }

        public void SetTimeOffset(int offset)
        {
            MinutesOffset = offset;
        }

        public void SetMinutesInterval(int minutes)
        {
            MinutesInterval = minutes;
            _isIntervalSet = true;
            TryAddIntervals();
        }

        public void SetStartTime(DateTime dateTime)
        {
            StartTime = dateTime;
            _isStartTimeSet = true;
            TryAddIntervals();
        }

        public void SetStopTime(DateTime dateTime)
        {
            StopTime = dateTime;
            _isStopTimeSet = true;
            TryAddIntervals();
        }

        public void SetDefaultSound(Sounds s)
        {
            DefaultSound = s;
            _isDefaultSoundSet = true;
        }

        private void TryAddIntervals()
        {
            //Checks whether interval alarms are ready to add, and if so adds them
            //Ignores the out variable to a wildcard variable
            if (AlarmAtStartTime &&
                FindAlarm(StartTime, AlarmMode.Sound, Sounds.AnalogWatch, "", out Alarm _) ==
                false)
                AddAlarm(new Alarm(AlarmMode.Sound, StartTime, true));
            if (_isStartTimeSet && _isStopTimeSet && _isIntervalSet && GetIntervalAlarms().Count <= 1)
            {
                var tempTime = StartTime;
                while (tempTime.AddMinutes(MinutesInterval) <= StopTime)
                {
                    AddAlarm(new Alarm(AlarmMode.Sound, tempTime.AddMinutes(MinutesInterval), true));
                    tempTime = tempTime.AddMinutes(MinutesInterval);
                }
            }
            SortTimes();
        }

        public void SetDefaultTTSMessage(string message)
        {
            DefaultTextToSpeechMessage = message;
        }


        public bool FindAlarm(DateTime time, AlarmMode mode, Sounds sound, string message, out Alarm outAlarm)
        {
            //Finds and alarm with the specified options and sets the outAlarm to it.
            foreach (var alarm in AlarmList)
                if (alarm.Message != null && message != null)
                {
                    if (alarm.AlarmTime.To24HourDateTimeString() == time.To24HourDateTimeString() &&
                        alarm.AlarmMode == mode && alarm.Sound == sound && alarm.Message == message)
                    {
                        outAlarm = alarm;
                        return true;
                    }
                }
                else
                {
                    if (alarm.AlarmTime.To24HourDateTimeString() == time.To24HourDateTimeString() &&
                        alarm.AlarmMode == mode && alarm.Sound == sound)
                    {
                        outAlarm = alarm;
                        return true;
                    }
                }
            outAlarm = new Alarm(AlarmMode.Sound, DateTime.MinValue, false);
            return false;
        }

        public void ToggleAlarm(Alarm alarm)
        {
            alarm.Enabled = !alarm.Enabled;
        }

        #endregion

        #region Alarm Management Methods

        public void DeleteAlarm(Alarm alarm)
        {
            //Removes alarm
            AlarmList.Remove(alarm);
        }

        public void AddAlarm(Alarm alarm)
        {
            //Adds alarm then sorts
            AlarmList.Add(alarm);
            SortTimes();
        }

        public void SortTimes()
        {
            //Sorts the times in ascending order
            AlarmList = AlarmList.OrderBy(alarm => alarm.AlarmTime).ToList();
        }

        public List<Alarm> GetIntervalAlarms()
        {
            //Returns a list of all alarms that are created as interval alarms
            SortTimes();
            var tempList = new List<Alarm>();
            foreach (var alarm in AlarmList)
                if (alarm.PartOfIntervalSet)
                    tempList.Add(alarm);
            return tempList;
        }

        public List<Alarm> GetSpecificAlarms()
        {
            //Returns a list of alarms created specifically
            SortTimes();
            var tempList = new List<Alarm>();
            foreach (var alarm in AlarmList)
                if (!alarm.PartOfIntervalSet && alarm.AlarmMode != AlarmMode.TextToSpeech)
                    tempList.Add(alarm);
            return tempList;
        }

        public List<Alarm> GetTextToSpeechAlarms()
        {
            //Returns a list of alarms created as text-to-speech
            SortTimes();
            var tempList = new List<Alarm>();
            foreach (var alarm in AlarmList)
                if (!alarm.PartOfIntervalSet && alarm.AlarmMode == AlarmMode.TextToSpeech)
                    tempList.Add(alarm);
            return tempList;
        }

        #endregion
    }
}