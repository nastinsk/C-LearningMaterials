using System;

namespace DateTimeFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime
            DateTime myDate = new DateTime();
            Console.WriteLine(myDate);

            DateTime date1 = new DateTime(2020, 11, 27, 12, 54, 52); //year, month, date, hour, minutes, seconds
            Console.WriteLine(date1);
            Console.WriteLine(date1.ToShortDateString());//11/27/2020
            Console.WriteLine(date1.ToShortTimeString());//12:54 PM
            Console.WriteLine(date1.AddDays(-4)); //11/23/2020 12:54:52 PM

            DateTime dateNow = DateTime.Now;
            Console.WriteLine(dateNow);

            string formattedDate = string.Format("{0:yyyy-MMMM-d HH:mm:ss tt}", dateNow); //here we use regex MMM -month abbreviation, MMMM - full month name, dddd - day of the week, tt- AM or PM Result: 2020-November-27 01:26:57 AM

            Console.WriteLine(formattedDate);

            string formattedDateTwo = string.Format("{0:dddd 'of month' MMMM 'year' yyyy}", date1); //Friday of month November year 2020
            Console.WriteLine(formattedDateTwo);

        }

    }
}
