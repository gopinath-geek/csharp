using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier
{
    class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                k = j = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
            }
            // Console.WriteLine(i); // Out side scope
            Console.WriteLine("Outside of the for {0}", j);
            Console.WriteLine("Outside of the for {0}", k);
            //Console.WriteLine("Outside of the for {0}", l); //Invalid 
            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething();
            Console.ReadKey();
        }
        static void HelperMethod()
        {
            Console.WriteLine("Out side function {0}", k);
        }
    }
    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }
        private string helperMethod()
        {
            return "Hello World!";
        }
    }
}