using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Mike", Age = 43 };
            Animal animale = new Animal { Age = 6, Name = "Bob the cat" };
            List<IRun> list = new List<IRun>();

            list.Add(person);
            list.Add(animale);

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name}, {item.Age}");

            }
            Console.ReadLine();
        }
    }
    public interface IRun : IDetails
    {
        void Run();
    }
    public interface IDetails
    {
        string Name { get; set; }
        int Age { get; set; }
    }
    public class Person : IRun, IDetails
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Run()
        {
            Console.WriteLine("This person is running.");
        }
    }
    public class Animal : IRun, IDetails
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Run()
        {
            Console.WriteLine("This animal is running.");
        }
    }
}
