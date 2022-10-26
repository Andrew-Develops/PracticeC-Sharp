using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            var rand = new Random();
            List<int> shuffleNumbers = new List<int>();
            shuffleNumbers = numbers.OrderBy(x => rand.Next()).ToList();

            foreach (int number in numbers)
            {
                Console.Write(number+" ");
            }
            Console.WriteLine();
            foreach (int number in shuffleNumbers)
            {
                Console.Write(number+" ");
            }

            Console.ReadLine();
        }
    }
}
