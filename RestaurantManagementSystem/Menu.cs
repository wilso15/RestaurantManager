using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Menu
    {
        List<MenuItem> MenuItems = new List<MenuItem>();

        public Menu()
        {

        }
        public void AddItemToMenu(MenuItem menuItem)
        {
            MenuItems.Add(menuItem);
        }
        public void DisplayMenuInventory()
        {
            for (int i = 0; i < MenuItems.Count; i++)
            {
                Console.WriteLine(MenuItems[i]);
            }
        }
        public void SetHappyHour()
        {
            foreach (MenuItem item in MenuItems)
            {
                item.price -= 2;
            }
        }
    }
}
