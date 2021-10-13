using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            ReadInput.PersonDetails();
            Console.ReadLine();
        }
    }
    class ReadInput
    {
        public static void PersonDetails()
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Address :");
            var Address = Console.ReadLine();

            Console.Write("Enter City :");
            string City = Console.ReadLine();

            Console.Write("Enter State :");
            string State = Console.ReadLine();

            Console.Write("Enter ZipCode :");
            string ZipCode = Console.ReadLine();

            Console.Write("Enter Phone Number :");
            string PhoneNumber = Console.ReadLine();

            Console.Write("Enter MailId :");
            string EmailId = Console.ReadLine();

            //NOW ADDING FETCHED DETAILS TO LIST

            List<string> PersonList = new List<string>();
            PersonList.Add(firstName);
            PersonList.Add(lastName);
            PersonList.Add(City);
            PersonList.Add(State);
            PersonList.Add(ZipCode);
            PersonList.Add(EmailId);
            foreach (string i in PersonList)
                Console.WriteLine(i);

        }
    }
}