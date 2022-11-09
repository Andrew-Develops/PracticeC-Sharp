using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGuestBook
{
    internal static class Guest
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Hello. Welcome to my party.");
            Console.WriteLine("Before you go in i need you to fill the guest book.");
        }
        public static void AddGuestToParty(Dictionary<string, int> list, string familyName, int numberOfPeople)
        {
            list.Add(familyName, numberOfPeople);
        }
        public static void PrintingParyList(Dictionary<string, int> list)
        {
            // Printing the list
            Console.WriteLine("The list of people in the party is:");
            int count = 0;
            foreach (var item in list)
            {
                Console.WriteLine(item.Key + " " + item.Value);
                count += item.Value;
            }
            Console.WriteLine("Total ammount of guests: " + count);
        }
        public static (string familyName, int numberOfPeople) GetFamilyInformation()
        {
            Console.Write("What is your family name: ");
            string getFamilyName = Console.ReadLine();
            Console.Write("How many people family members: ");
            string getFamilyMembers = Console.ReadLine();
            int familyMembers = int.Parse(getFamilyMembers);

            return (getFamilyName, familyMembers);
        }
        public static bool KeepAddingMembers()
        {
            bool result = false;
            Console.WriteLine("To add another family press 'y' or 'n'.");
            string addMore = Console.ReadLine();
            if (addMore == "n")
            {
                result = true;
            }
            return result;
        }
    }
}
