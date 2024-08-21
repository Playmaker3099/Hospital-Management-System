using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class Appointment : ISchedulable
    {
        public int Price { get; set; }

        public DateTime Time { get; set; }
        public bool booking {  get; set; }
        //public int consult;
        public Appointment(int price, DateTime time) 
        {
            Price = price;
            Time = time;
        }

        public void Schedule(bool Booking)
        {
            booking = Booking;
            if (Booking) 
            {

               Console.WriteLine( $"A booking has been made for {DateTime.Now}");
            }
            Booking = true;
        }

        public void Cancel(bool Booking )
        {
            booking = Booking;
            if (!Booking) 
            {
                Console.WriteLine( $"No booking has been made");
            }

            Booking = false;
        }
        public virtual int CalculateBill(int price, int consult) 
        {
            Price = price;
            

            int result = price + consult;

            return result;
        }
    }
}
