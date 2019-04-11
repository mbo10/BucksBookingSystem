using System;
using System.Collections.Generic;
using System.Text;

namespace ShowBookingSystem
{
    class Customer
    {
        protected string firstName;
        protected string surname;
        protected string address;
        public void CustomerInfo()
        {
            firstName = "";
            surname = "";
            address = "";
        }
        public void GetLogin()
        {
            string username;
            string password;

            Console.WriteLine("------------------------------------ LOG IN ------------------------------------");
            Console.WriteLine("Welcome to the Bucks Centre for Performing Arts ticket purchasing");
            Console.WriteLine("Please log in.");
            Console.WriteLine("Enter username: ");
            username = Console.ReadLine();

            while (username.Length > 10)
            {
                Console.WriteLine("Your username should be no more than 10 characters long.");
                Console.WriteLine("Please re-enter your username: ");
                username = Console.ReadLine();
            }

            Console.WriteLine("Enter password: ");
            password = Console.ReadLine();

            while (password.Length > 10)
            {
                Console.WriteLine("Your password should be no more than 10 characters long.");
                Console.WriteLine("Please re-enter your password: ");
                password = Console.ReadLine();
            }
        }

        public void GetProfileInfo(string firstName, string surname, string address)
        {
            Console.WriteLine("Please enter your personal details.");
            Console.WriteLine("Enter your First name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your Surname: ");
            surname = Console.ReadLine();
            Console.WriteLine("Enter your Address: ");
            address = Console.ReadLine();
            Console.WriteLine("");

            this.firstName = firstName;
            this.surname = surname;
            this.address = address;
        }
    }
}
