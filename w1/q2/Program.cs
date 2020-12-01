using System;

// ideal universe: 30 days in every month, 12 months a year

namespace q2
{
    class Program
    {

        static int getIntFromStrDate(string inputDate, int a, int b)
        {
            string temp = "" + inputDate[a] + inputDate[b];

            int ans = 0;
            int.TryParse(temp, out ans);

            return ans;
        }

        static long convertStrDateToSeconds(string inputDate)
        {
            int DD = getIntFromStrDate(inputDate, 0,1);
            int MM = getIntFromStrDate(inputDate, 3, 4);
            int YY = getIntFromStrDate(inputDate, 6, 7);

            int hh = getIntFromStrDate(inputDate, 9, 10);
            int mm = getIntFromStrDate(inputDate, 12, 13);
            int ss = getIntFromStrDate(inputDate, 15, 16);

            //Console.WriteLine(DD.ToString() + " " + MM.ToString() + " " + YY.ToString() + " " + hh.ToString() + " " + mm.ToString() + " " + ss.ToString());

            long ans = 0;

            ans = ss;

            ans += mm * 60;

            ans += hh * 60 * 60;

            ans += DD * 24 * 60 * 60;

            ans += MM * 30 * 24 * 60 * 60;

            ans += YY * 12 * 30 * 24 * 60 * 60;

            return ans;
        }

        static string convertSecDateToStr(long ansInSec)
        {
            long DD, MM, YY, hh, mm, ss;

            YY = ansInSec / (12 * 30 * 24 * 60 * 60);
            ansInSec = ansInSec % (12 * 30 * 24 * 60 * 60);

            MM = ansInSec / (30 * 24 * 60 * 60);
            ansInSec = ansInSec % (30 * 24 * 60 * 60);

            DD = ansInSec / (24 * 60 * 60);
            ansInSec = ansInSec % (24 * 60 * 60);

            hh = ansInSec / (60 * 60);
            ansInSec = ansInSec % (60 * 60);

            mm = ansInSec / (60);
            ansInSec = ansInSec % (60);

            ss = ansInSec;

            return DD.ToString()+ ":" + MM.ToString() + ":" + YY.ToString() + ":" + hh.ToString() + ":" + mm.ToString() + ":" + ss.ToString();
        }

        static string addSeconds(string inputDate, long secondsToBeAdded)
        {
            long inputDateInSec = convertStrDateToSeconds(inputDate);

            long ansInSec = inputDateInSec + secondsToBeAdded;

            string ans = "";

            ans = convertSecDateToStr(ansInSec);

            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter date in 'DD:MM:YY:hh:mm:ss' format.");
            string inputDate = Console.ReadLine();

            Console.WriteLine("Enter the number of ticks.");
            string inputTickStr = Console.ReadLine();
            long inputTickCount = 0;
            long.TryParse(inputTickStr, out inputTickCount);

            long secondsToBeAdded = (inputTickCount / 10000000); // assuming secondsToBeAdded is a whole number

            string ans = addSeconds(inputDate, secondsToBeAdded);

            Console.WriteLine("Answer is {0}.",ans);
        }
    }
}


//10:10:10:10:10:10
//50000000
//600000000

//30:12:00:23:59:59
//10000000