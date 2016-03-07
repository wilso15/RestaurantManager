using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class KitchenStaff : Employee
    {
        string kitchenSection;
        enum KitchenStaffPositions
        {
            chef, dishwasher
        }

        public KitchenStaff(string name, int age, double payRate, bool hasCleanArea, string kitchenSection) : base(name, age, payRate, hasCleanArea)
        {
            this.name = name;
            this.age = age;
            this.payRate = payRate;
            this.hasCleanArea = hasCleanArea;
            this.kitchenSection = kitchenSection;
        }
    }
}
