using System;
using System.Collections.Generic;
using System.Text;

namespace ShowBookingSystem
{
    class Show
    {
        protected string showName;
        protected string showDate;
        protected string showTime;
        public void ShowDetails()
        {
            showName = "";
            showDate = "";
            showTime = "";
        }

        public void SelectShow(string showName, string showDate)
        {
            string ch;

            Console.WriteLine("---------- SELECT AN UPCOMING SHOW ----------");
            Console.WriteLine("1. Fight Club (20/04/2019)");
            Console.WriteLine("2. Scarface (01/05/2019)");
            Console.WriteLine("3. Bad Boys (25/04/2019)");
            Console.WriteLine("Please select a show number: ");
            ch = Console.ReadLine();

            while (ch != "1" && ch != "2" && ch != "3")
            {
                Console.WriteLine("Please select a valid show number: ");
                ch = Console.ReadLine();
            }

            switch (ch)
            {
                case "1":
                    showName = "Fight Club";
                    showDate = "20/04/2019";
                    break;
                case "2":
                    showName = "Scarface";
                    showDate = "01/05/2019";
                    break;
                case "3":
                    showName = "Bad Boys";
                    showDate = "25/04/2019";
                    break;
            }
            this.showName = showName;
            this.showDate = showDate;
        }

        public void SelectTime(string showTime)
        {
            var showSeat = new ShowSeat();
            string time;

            Console.WriteLine("---------- SELECT SHOW TIME ----------");
            Console.WriteLine("1. 13:00 screening.");
            Console.WriteLine("2. 19:00 screening.");
            Console.WriteLine("Please select a showing time.");
            time = Console.ReadLine();

            while (time != "1" && time != "2")
            {
                Console.WriteLine("Please enter a valid option.");
                time = Console.ReadLine();
            }

            switch (time)
            {
                case "1":
                    showTime = "13:00 screening.";
                    break;
                case "2":
                    showTime = "19:00 screening.";
                    break;
            }
            this.showTime = showTime;
        }
    }
}
