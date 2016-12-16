using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime myValue = DateTime.Now;
            //DateTime today = DateTime.Today;
            //Console.WriteLine(today.ToString());
            //Console.WriteLine(today.Date.ToString());
            //Console.WriteLine(today.Day.ToString());
            //Console.WriteLine(today.DayOfWeek.ToString());
            //Console.WriteLine(today.DayOfYear.ToString());
            //Console.WriteLine(today.Hour.ToString());
            //Console.WriteLine(DateTime.Parse("04/12/1991"));
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(-2).ToLongDateString());
            //Console.WriteLine(myValue.AddDays(-2).ToString());

            DateTime myBirthday = new DateTime(1991, 04, 12, 11, 00, 15);
            Console.WriteLine(myBirthday.ToString());
            //DateTime myBirthday = DateTime.Parse("04/12/1991");
            //TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            //Console.WriteLine(myAge.TotalDays);
            Console.ReadKey();
        }
    }
}
