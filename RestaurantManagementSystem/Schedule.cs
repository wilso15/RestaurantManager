using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Schedule
    {
        public List<string> DaysOfTheWeek;
            public Schedule()
        {
            this.DaysOfTheWeek = new List<string>();
        }

        public void BeginRestaurant()
        {
            Menu menu1 = new Menu();
            Restaurant restaurant = new Restaurant(menu1);
            MenuItem Beef = new MenuItem("Food", "Beef Stew", 12);
            MenuItem Wine = new MenuItem("Beverage", "Cabernet Sauvignon", 15);
            menu1.AddItemToMenu(Beef);
            menu1.AddItemToMenu(Wine);
            menu1.DisplayMenuInventory();
            BarStaff BartenderNick = new BarStaff("Nick", 26, 10, true, "1A");
            restaurant.HireNewEmployee(BartenderNick);
            BartenderNick.UndergoTraining(BartenderNick);
            KitchenStaff ChefBoy = new KitchenStaff("ChefBoyRDee", 44, 20, false, "Dishes");
            restaurant.HireNewEmployee(ChefBoy);
            WaitStaff Baller = new WaitStaff("Baller", 32, 12, true, "A");
            restaurant.HireNewEmployee(Baller);
            Customer customer1 = new Customer("Wilson", 2, "8:00PM");
            customer1.MakeReservation(customer1);
            restaurant.FireCurrentEmployee(restaurant.allEmployees[0]);

            foreach (string item in DaysOfTheWeek)
            {
                switch (item)
                {
                    case "Sunday":
                        {
                            restaurant.SetDailyWaitEmployee();
                            restaurant.SetDailyBarEmployee();
                            restaurant.SetDailyKitchenEmployee();
                            restaurant.CheckIfAreaIsClean(DaysOfTheWeek);
                            restaurant.ResetDailyEmployeeStaff();
                            menu1.SetHappyHour();
                            break;
                        }
                    case "Monday":
                        {
                            restaurant.SetDailyWaitEmployee();
                            restaurant.SetDailyBarEmployee();
                            restaurant.SetDailyKitchenEmployee();
                            restaurant.ResetDailyEmployeeStaff();
                            break;
                        }
                    case "Tuesday":
                        {
                            restaurant.SetDailyWaitEmployee();
                            restaurant.SetDailyBarEmployee();
                            restaurant.SetDailyKitchenEmployee();
                            menu1.SetHappyHour();
                            restaurant.ResetDailyEmployeeStaff();
                            break;
                        }
                    case "Wednesday":
                        {
                            restaurant.SetDailyWaitEmployee();
                            restaurant.SetDailyBarEmployee();
                            restaurant.SetDailyKitchenEmployee();
                            restaurant.ResetDailyEmployeeStaff();
                            break;
                        }
                    case "Thursday":
                        {
                            restaurant.SetDailyWaitEmployee();
                            restaurant.SetDailyBarEmployee();
                            restaurant.SetDailyKitchenEmployee();
                            menu1.SetHappyHour();
                            restaurant.ResetDailyEmployeeStaff();
                            break;
                        }
                    case "Friday":
                        {
                            restaurant.SetDailyWaitEmployee();
                            restaurant.SetDailyBarEmployee();
                            restaurant.SetDailyKitchenEmployee();
                            restaurant.ResetDailyEmployeeStaff();
                            break;
                        }
                    case "Saturday":
                        {
                            restaurant.SetDailyWaitEmployee();
                            restaurant.SetDailyBarEmployee();
                            restaurant.SetDailyKitchenEmployee();
                            restaurant.ResetDailyEmployeeStaff();
                            break;
                        }
                     
                }
            }
        }
    }
}
