using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class WaitStaff : Employee
    {
        string tableSection;
        enum WaitStaffPositions
        {
            waiter, host, busser
        }
        
        public WaitStaff(string name, int age, double payRate, bool hasCleanArea, string tableSection) : base(name, age, payRate, hasCleanArea)
        {
            this.name = name;
            this.age = age;
            this.payRate = payRate;
            this.hasCleanArea = hasCleanArea;
            this.tableSection = tableSection;
        }
    }
}
