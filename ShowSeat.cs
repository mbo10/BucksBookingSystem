using System;
using System.Collections.Generic;
using System.Text;

namespace ShowBookingSystem
{
    class ShowSeat
    {
        protected int numSeats;
        public int GetNumSeats()
        {
            Console.WriteLine("------- SELECT NUMBER OF SEATS TO BUY ------");
            Console.WriteLine("How many tickets would you like to purchase (Max. 8)?: ");
            numSeats = Convert.ToInt32(Console.ReadLine());
            return numSeats;
        }
        public void CompletePurchase()
        {
            int seatPrice = 9;
            int totalPrice = numSeats * seatPrice;
            Console.WriteLine("The total price for " + numSeats + " seats will be " + totalPrice + " £");
            Console.WriteLine("Would you like to continue with your purchase? [Y/N]");
            string choice = Console.ReadLine();

            while (choice != "Y" && choice != "N")
            {
                Console.WriteLine("Please enter Y or N to confirm or deny.");
                choice = Console.ReadLine();
            }

            switch (choice)
            { 
                case "Y":
                    Console.WriteLine("Thank you! You have purchased " + numSeats + " tickets for your show!");
                    break;
                case "N":
                    Console.WriteLine("Changed your mind? That's okay! You can come back and purchase your tickets any time!");
                    break;
            }
        }
    }
}
