using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapUpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel
                {
                    FirstName = "Tim",
                    LastName = "CoreyHeck",
                    Email = "tim@gmail.com"
                },
                new PersonModel
                {
                    FirstName = "Mike",
                    LastName = "Tyson",
                    Email = "tyson@gmail.com"
                },
                new PersonModel
                {
                    FirstName = "Joe",
                    LastName = "Smith",
                    Email = "Smith@gmail.com"
                }
            };
            List<CarModel> cars = new List<CarModel>
            {
                new CarModel
                {
                    Manufacturer = "Toyota",
                    Model = "Corolla"
                },
                new CarModel
                {
                    Manufacturer = "Toyota",
                    Model = "Highlander"
                },
                new CarModel
                {
                    Manufacturer = "Ford",
                    Model = "MustangHeck"
                }
            };

            DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();
            peopleData.BadEntryFound += PeopleData_BadEntryFound;
            peopleData.SaveToCSV(people, @"C:\Users\Andrew\Documents\GitHub\PracticeC-Sharp\SmallTasks\WrapUpDemoApp\people.csv");

            DataAccess<CarModel> carData = new DataAccess<CarModel>();
            carData.BadEntryFound += CarData_BadEntryFound;
            carData.SaveToCSV(cars, @"C:\Users\Andrew\Documents\GitHub\PracticeC-Sharp\SmallTasks\WrapUpDemoApp\cars.csv");

            Console.ReadLine();
        }

        private static void CarData_BadEntryFound(object sender, CarModel e)
        {
            Console.WriteLine();
            Console.WriteLine($"Bad entry found for {e.Manufacturer} {e.Model}");
            Console.WriteLine();
        }

        private static void PeopleData_BadEntryFound(object sender, PersonModel e)
        {
            Console.WriteLine();
            Console.WriteLine($"Bad entry found for {e.FirstName} {e.LastName}");
            Console.WriteLine();
        }
    }
}
