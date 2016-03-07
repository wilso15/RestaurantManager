using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class MenuItem : Menu
    {
        public string type;
        public string name;
        public int price;
        public MenuItem(string type, string name, int price)
        {
            this.type = type;
            this.name = name;
            this.price = price;
        }
        public override string ToString()
        {
            return "Menu Item: " + name + "|| Price: " + price;
        }
    }
}
