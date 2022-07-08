using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    internal class TestClass
    {
        public enum Days
        { 
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        }
        public static Days GetDays
        {
            get; set;
        }

        public enum DayWithIndex
        {
            Monday=1, Tuesday=2, Wednesday=3, Thursday=14, Friday=5, Saturday=6, Sunday=7
        }
        static void Main()
        {
            DayWithIndex dw1 = (DayWithIndex)1;
            Days d = 0;
            Days d1 = (Days)1;
            Days d2 = (Days)5;
            Days d3 = Days.Sunday;

            Console.WriteLine("Value of d = " + dw1);
            Console.WriteLine("Value of d = "+d);
            Console.WriteLine("Value of d = "+d1);
            Console.WriteLine("Value of d = "+d2);
            Console.WriteLine("integer representation of d = "+(int)d3);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello world");

            Console.WriteLine(GetDays);
            Console.WriteLine("Print index");

            foreach (int i in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine("value index = " + i);

            }

            Console.WriteLine("print names");

            foreach (string i in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine("value names = " + i);

            }

            Console.WriteLine("Print index with names");

            foreach (int i in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine("value index = " + i+ " : "+(Days)i );

            }


            Console.ReadLine();
        }
    }
}
