using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Capture the information about each guest (assumtion is at least one guest and unknown maximum)
// Info to capture: First name, last name, message to the host
// Once done, loop through each guest and print their info

namespace ConsoleUI
{
    internal class Program
    {
        private static void GetGuestInformation(List<GuestModel> guests)
        {
            string moreGuestComming = "";

            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetInformationFromConsole("What is your first name: ");
                guest.LastName = GetInformationFromConsole("What is your last name: ");
                guest.MessageToHost = GetInformationFromConsole("What message would you like to tell the host: ");

                moreGuestComming = GetInformationFromConsole("Are you gues comming 'yes' or 'no'.");

                Console.Clear();

                guests.Add(guest);

            } while (moreGuestComming.ToLower() == "yes");
        }
        private static string GetInformationFromConsole(string message)
        {
            string output = "";

            Console.WriteLine(message);
            output = Console.ReadLine();

            return output;
        } 
        private static void PrintGuestInformation(List<GuestModel> guests)
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }

        static void Main(string[] args)
        {
            List<GuestModel> guests = new List<GuestModel>();

            GetGuestInformation(guests);
            PrintGuestInformation(guests);
            
            Console.ReadLine();
        }
    }
}
