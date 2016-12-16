using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();

            car1.Make = "Geo";
            car1.Model = "Prism";
            car1.VIN = "B01";

            car2.Make = "BMW";
            car2.Model = "Cutlas Supreme";
            car2.VIN = "B02";
            Book book1 = new Book();
            book1.BookName = "Microsoft .Net";
            book1.ISBN = "0-000-00000-0";

            List<Car> myCarList = new List<Car>();

            myCarList.Add(car1);
            //Console.WriteLine(myCarList[0].Make);
            
   
            // Dictionary<TKey, TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            // Object initializer
            //Car car3 = new Car { Make="Oldsmobile",Model="Cutlas",VIN="E5" };
            //Car car4 = new Car { Make = "Nissan", Model = "Altina", VIN = "F6" };

            //Collection initializer
            List<Car> myCarList2 = new List<Car>() { 
                new Car { Make="Oldsmobile",Model="Cutlas",VIN="E5" },
                new Car { Make="Nissan",Model="Altina",VIN="F6" }
            };

            Console.WriteLine(myCarList2[0].Make);
            Console.ReadLine();
        }
    }
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
    class Book
    {
        public string BookName { get; set; }
        public string ISBN { get; set; }
    }
}
