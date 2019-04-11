using System;
using System.Collections.Generic;
using System.Text;

namespace ShowBookingSystem
{
    class Menu
    {
        public void MainMenu()
        {
            string showName = "", showDate = "", showTime = "";
            var show = new Show();
            var showSeat = new ShowSeat();

            string choice;

            Console.WriteLine("-------- MAIN MENU --------");
            Console.WriteLine("1. Buy tickets for a show");
            Console.WriteLine("2. EXIT");
            Console.WriteLine("Please enter a menu choice number.");
            choice = Console.ReadLine();

            while (choice != "1" && choice != "2")
            {
                Console.WriteLine("Please select a valid option.");
                choice = Console.ReadLine();
            }

            switch (choice)
            {
                case "1":
                    show.SelectShow(showName, showDate);
                    show.SelectTime(showTime);
                    showSeat.GetNumSeats();
                    showSeat.CompletePurchase();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
            };
        }
    }
}
