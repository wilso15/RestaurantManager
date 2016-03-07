using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Employee
    {
        public string name;
        public int age;
        public double payRate;
        public bool isTrained;
        public bool hasCleanArea;
        public int daysTrained;
        public Employee(string name, int age, double payRate, bool hasCleanArea)
        {
            this.name = name;
            this.age = age;
            this.payRate = payRate;
            isTrained = false;
            this.hasCleanArea = hasCleanArea;
            daysTrained = 0;
        }

        public void UndergoTraining(Employee employee)
        {
            if (isTrained == false && daysTrained < 5)
            {
                for (daysTrained = 0; daysTrained < 6; daysTrained++)
                {
                    if (daysTrained == 5)
                    {
                        isTrained = true;
                    }
                }
            }
            
        }
    public override string ToString()
    {
        return "Name: " + name + ", Age: " + age + ", Pay Rate: " + payRate + ", Has Training: " + isTrained + "||";
    }
}
}
