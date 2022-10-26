using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel("Tim","Corey");
            person.GenerateEmail();

            Console.WriteLine(person.Email);

            Console.ReadLine();

        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        public PersonModel(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public PersonModel()
        {

        }

        public void GenerateEmail()
        {
            GenerateEmail(false,"aol.com");
        }
        public void GenerateEmail(string domain)
        {
            GenerateEmail(false, domain);
        }
        public void GenerateEmail(bool firstInitialMethod)
        {
            GenerateEmail(firstInitialMethod, "aol.com");

        }

        public void GenerateEmail(bool firstInitialMethod,string domain)
        {
            if (firstInitialMethod == true)
            {
                Email = $"{FirstName.Substring(0, 1)}.{LastName}@{domain}";
            }
            else
            {
                Email = $"{FirstName}{LastName}@{domain}";
            }
        }

    }
}
