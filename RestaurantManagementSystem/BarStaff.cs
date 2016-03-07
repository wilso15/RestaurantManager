using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class BarStaff : Employee
    {
        string barSection;
        enum BarStaffPositions
        {
            bartender
        }
        public BarStaff(string name, int age, double payRate, bool hasCleanArea, string barSection) : base(name, age, payRate, hasCleanArea)
        {
            this.name = name;
            this.age = age;
            this.payRate = payRate;
            this.hasCleanArea = hasCleanArea;
            this.barSection = barSection;
        }
    }
}
