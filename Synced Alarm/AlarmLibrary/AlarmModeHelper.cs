namespace AlarmLibrary
{
    public static class AlarmModeHelper
    {
        public static AlarmMode GetAlarmModeFromString(this string alarmModeString)
        {
            if (alarmModeString == "Sound")
                return AlarmMode.Sound;
            if (alarmModeString == "Text-to-Speech" || alarmModeString == "TextToSpeech")
                return AlarmMode.TextToSpeech;
            return AlarmMode.Sound;
        }
    }
}