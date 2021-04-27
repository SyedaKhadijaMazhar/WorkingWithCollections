using System;
using System.Collections;
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
            /*
            Car car1 = new Car();
            car1.Make = "Oldsmbile";
            car1.Model = "Cutlus Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B2";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .Net XML Web Services";
            b1.ISBN = "0-000-00000-0";
            */
            // ArrayList are dynamicaly sized
            // cool features sorting, remove items.
            /*
            ArrayList Myarr = new ArrayList();
            Myarr.Add(car1);
            Myarr.Add(car2);
            Myarr.Add(b1);
            foreach (Car car in Myarr)

            {
                Console.WriteLine(car.Make);
            }
            */
            /*
            List<Car> myCar = new List<Car>();
            myCar.Add(car1);
            myCar.Add(car2);
            foreach (Car item in myCar)

            {
                Console.WriteLine(item.Make);
            }
            */
            // Dictionary <TKey, TValue>
            /*
            Dictionary<string, Car> MyDictionary = new Dictionary<string, Car>();
            MyDictionary.Add(car1.VIN, car1);
            MyDictionary.Add(car2.VIN, car2);
             Console.WriteLine(MyDictionary["A1"].Model);
            */
            // Object Initializer
            // No need for Constructor
            //  Car car1 = new Car() { Make = "BMW", Model = "123AI", VIN = "C3" };
            // Car car2 = new Car() { Make = "Toyota", Model = "4058T5", VIN "D4" };
            //Collection Initializer

            List<Car> myList = new List<Car>()
            {
                new Car {Make = "BMW", Model = "123B7", VIN= "C3"},
                new Car {Make = "Toyota", Model = "234T54", VIN= "D4"}
                
            };


           
            Console.ReadLine();
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }

    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

    }
}
