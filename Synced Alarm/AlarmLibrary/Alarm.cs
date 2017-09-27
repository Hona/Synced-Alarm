using System;

namespace AlarmLibrary
{
    public class Alarm
    {
        public Alarm(AlarmMode mode, DateTime alarmTime, bool partOfSet)
        {
            AlarmMode = mode;
            AlarmTime = alarmTime;
            if (AlarmMode == AlarmMode.TextToSpeech)
                Sound = Sounds.TextToSpeech;
            PartOfIntervalSet = partOfSet;
        }

        public bool Enabled { get; set; } = true;

        public DateTime AlarmTime { get; private set; }
        public string Message { get; private set; }
        public Sounds Sound { get; private set; }
        public AlarmMode AlarmMode { get; }
        public bool PartOfIntervalSet { get; }
        public bool AlarmTriggered { get; set; }

        public bool IsInitialized
        {
            get
            {
                switch (AlarmMode)
                {
                    case AlarmMode.Sound:
                        return AlarmTime != DateTime.MinValue;
                    case AlarmMode.TextToSpeech:
                        return AlarmTime != DateTime.MinValue && !string.IsNullOrEmpty(Message);
                }
                return false;
            }
        }

        public void SetSound(Sounds sound)
        {
            Sound = sound;
        }

        public void SetTime(DateTime dateTime)
        {
            AlarmTime = dateTime;
        }

        public void SetMessage(string message)
        {
            Message = message;
        }

        public string GetAlarmModeString()
        {
            switch (AlarmMode)
            {
                case AlarmMode.Sound:
                    return "Sound";
                case AlarmMode.TextToSpeech:
                    return "Text-to-Speech";
                default:
                    return "New mode not implemented";
            }
        }

        public string GetSoundString()
        {
            switch (Sound)
            {
                case Sounds.AnalogWatch:
                    return "Analog Watch";
                case Sounds.SchoolBell:
                    return "School Bell";
                case Sounds.AnnoyingAlarm:
                    return "Annoying Alarm";
                case Sounds.TextToSpeech:
                    return "Text-to-Speech";
                default:
                    return "Sound not implemented";
            }
        }

        public override string ToString()
        {
            //Format: Enabled,AlarmTime,Message,Sound,AlarmMode,PartOfIntervalSet
            return $"{Enabled},{AlarmTime.To24HourDateTimeString()},{Message},{Sound},{AlarmMode},{PartOfIntervalSet}";
        }
    }
}