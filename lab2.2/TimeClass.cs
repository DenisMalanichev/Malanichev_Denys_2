using System.Threading;

namespace lab2._2
{
    internal class TimeClass
    {

        public int Hours { get; set; }        
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public TimeClass(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public TimeClass()
        {
            Hours = 10;
            Minutes = 12;
            Seconds = 38;
        }
        override public string ToString()
        {
            string line = Hours + ":" + Minutes + ":" + Seconds;
            return line;
        }
        public void Clock()
        {
            Thread.Sleep(1000);
            Seconds++;
            if (Seconds >= 60)
            {
                Seconds = 0;
                Minutes++;
            }
            if (Minutes >= 60)
            {
                Minutes = 0;
                Hours++;
            }
            if (Hours >= 24)
            {
                Hours = 0;
            }
            Clock();
        }

        //Різниця двох відрізків часу в секундах
        public int Differens(int NHours, int NMins, int NSec)
        {
            return Hours * 60 * 60 + Minutes * 60 + Seconds - (NHours * 60 * 60 + NMins * 60 + NSec);
        }
        public void AddSec(int sec)
        {
            Hours += sec / 60 / 60;
            Minutes += sec / 60;
            Seconds += (sec - Hours * 60 * 60 - Minutes * 60);
        }
    }

}
