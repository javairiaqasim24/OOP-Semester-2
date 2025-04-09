using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    public class ClockType
    {
        public int seconds;
        public int minutes;
        public int hours;

        public ClockType()
        {
            seconds = 0;
            minutes = 0;
            hours = 0;

        }

        public ClockType(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;

        }

        public void PrintTime()
        {
            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }

        public int ElapseTime()
        {
            return (hours * 3600) + (minutes * 60) + seconds;
        }

        public void RemainingTime()
        {
            int rsecond = 24 * 3600;
            int remain = rsecond - ElapseTime();

            int rHours = remain / 3600;
            int rMinutes = (remain % 3600) / 60;
            int rSeconds = remain % 60;

            Console.WriteLine($"{rHours}:{rMinutes}:{rSeconds}");

        }

        public static void TimeDifference(ClockType clock3, ClockType clock4)
        {
            int second1 = (clock3.hours * 3600) + (clock3.minutes * 60) + clock3.seconds;
            int second2 = (clock4.hours * 3600) + (clock4.minutes * 60) + clock4.seconds;

            int difference = Math.Abs(second1 - second2);     //math.Abs remove the negative sign it just like mode

            int diffHours = difference / 3600;
            int diffMinutes = (difference % 3600) / 60;
            int diffSeconds = difference % 60;

            Console.WriteLine($"{diffHours}:{diffMinutes}:{diffSeconds}");

        }

    }
}
