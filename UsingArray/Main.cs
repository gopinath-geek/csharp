using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]{"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            int count = 0;
            foreach (string name in names)
            {
                foreach (char nameChar in name)
                {
                    if (count <= 5)
                    {
                        Console.Write(nameChar);
                        count++;
                    }
                    else
                    {
                        count = 0;
                        break;
                    }
                }
                count = 0;
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
