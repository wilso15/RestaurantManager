using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Customer
    {
        string name;
        int partySize;
        string timeOfReservation;
        public Customer(string name, int partySize, string timeOfReservation)
        {
            this.name = name;
            this.partySize = partySize;
            this.timeOfReservation = timeOfReservation;
        }
        public void MakeReservation(Customer customer)
        {
            FileWriter.WriteToFile("RestaurantManagementSystem.txt", customer);
        }

        public override string ToString()
        {
            return "Name of Customer: " + name + "|| Party Size: " + partySize + "|| Time of Reservation: " + timeOfReservation;
        }
    }
}
