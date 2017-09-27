namespace AlarmLibrary
{
    public static class SoundsHelper
    {
        public static Sounds GetSoundFromString(this string soundText)
        {
            if (soundText == "Analog Watch" || soundText == "AnalogWatch")
                return Sounds.AnalogWatch;
            if (soundText == "Annoying Alarm" || soundText == "AnnoyingAlarm")
                return Sounds.AnnoyingAlarm;
            if (soundText == "School Bell" || soundText == "SchoolBell")
                return Sounds.SchoolBell;
            if (soundText == "Text-to-Speech" || soundText == "TextToSpeech")
                return Sounds.TextToSpeech;

            return Sounds.SchoolBell;
        }
    }
}