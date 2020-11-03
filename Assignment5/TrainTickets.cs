using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Passenger
    {
       internal string PName;
        internal int PAge;
        internal Passenger(string PName, int PAge)
        {
            this.PName = PName;
            this.PAge = PAge;
        }
        public void TicketBooking(int no_of_tickets)
        {
            try
            {
                if (no_of_tickets > 2)
                {
                    Console.WriteLine("cannot book more than 2 tickets");
                }
                else
                {
                    Console.WriteLine("Ticket Booked Successfully");
                }
            }
            catch
            {
                Console.WriteLine("ex.Message");
            }       
         }
    }
    class TrainTickets
    {
        static void Main()
        {
            Passenger passenger = new Passenger("Haari",23);
            Console.WriteLine("Enter name of the passenge:{0}",passenger.PName);
            Console.WriteLine("Enter the age of the passenger:{0}",passenger.PAge);
            Console.WriteLine("Enter no of tickets to be booked");
            int nooftickets = Convert.ToInt32(Console.ReadLine());
            passenger.TicketBooking(nooftickets);

            Console.Read();
        }
    }
}
