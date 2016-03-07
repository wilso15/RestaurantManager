using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Schedule schedule = new Schedule();
            schedule.DaysOfTheWeek.Add("Sunday");
            schedule.DaysOfTheWeek.Add("Monday");
            schedule.DaysOfTheWeek.Add("Tuesday");
            schedule.DaysOfTheWeek.Add("Wednesday");
            schedule.DaysOfTheWeek.Add("Thursday");
            schedule.DaysOfTheWeek.Add("Friday");
            schedule.DaysOfTheWeek.Add("Saturday");
            schedule.BeginRestaurant();
            Console.ReadLine();
        }
    }
}
