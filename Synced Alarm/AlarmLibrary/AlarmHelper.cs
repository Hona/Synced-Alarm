using System;

namespace AlarmLibrary
{
    public static class AlarmHelper
    {
        public static Alarm GetAlarmFromString(this string fromString)
        {
            //Format: Enabled,AlarmTime,Message,Sound,AlarmMode,PartOfIntervalSet
            //AlarmMode, AlarmTime,PartOfIntervalSet
            var toReturnAlarm = new Alarm(fromString.Split(',')[4].GetAlarmModeFromString(),
                fromString.Split(',')[1].ToDateTimeFrom24HourString(), Convert.ToBoolean(fromString.Split(',')[5]))
            {
                Enabled = Convert.ToBoolean(fromString.Split(',')[0])
            };

            toReturnAlarm.SetMessage(fromString.Split(',')[2]);
            toReturnAlarm.SetSound(fromString.Split(',')[3].GetSoundFromString());

            return toReturnAlarm;
        }
    }
}