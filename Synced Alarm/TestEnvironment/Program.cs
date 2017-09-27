using System;
using System.Threading;
using AlarmLibrary;

namespace TestEnvironment
{
    internal class Program
    {
        private static void Main()
        {
            SoundAlarm(Sounds.TextToSpeech);
        }

        public static void SoundAlarm(Sounds sound)
        {
            switch (sound)
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

                    break;
            }
        }
    }
}