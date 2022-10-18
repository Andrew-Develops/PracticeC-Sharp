using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCalling
{
    internal class UserInput
    {
        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome to my application.");
        }
        public static string GetUserName()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            return name;
        }
        public static void GreetUser(string name)
        {
            Console.WriteLine($"Hello {name}.");
        }
    }
}
