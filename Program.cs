using System;

namespace ShowBookingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName ="", surname = "", address = "";
            var customer = new Customer();
            var menu = new Menu();

            customer.GetLogin();
            customer.GetProfileInfo(firstName, surname, address);
            menu.MainMenu();
        }
    }
}
