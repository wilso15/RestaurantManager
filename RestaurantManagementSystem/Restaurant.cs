using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Restaurant
    {
        public List<Employee> allEmployees;
        public List<Employee> allEmployeesWorkingToday;
        int employeeCounter;
        Schedule schedule = new Schedule();

        public Restaurant(Menu menu)
        {
            this.allEmployees = new List<Employee>();
            this.allEmployeesWorkingToday = new List<Employee>();
            employeeCounter = 0;

        }

        public void HireNewEmployee(Employee employee)
        {
            allEmployees.Add(employee);
            employeeCounter += 1;
        }
        public void FireCurrentEmployee(Employee employee)
        {
            for (int i = 0; i < allEmployees.Count; i++)
            {
                allEmployees.Remove(employee);
            }
            employeeCounter -= 1;
        }
        public void SetDailyWaitEmployee()
        {
            for (int i = 0; i < allEmployees.Count; i++)
            {
                if (allEmployees[i] is WaitStaff)
                {
                    allEmployeesWorkingToday.Add(allEmployees[i]);
                }
            }
        }
        public void SetDailyBarEmployee()
        {
            for (int i = 0; i < allEmployees.Count; i++)
            {
                if (allEmployees[i] is BarStaff)
                {
                    allEmployeesWorkingToday.Add(allEmployees[i]);
                }
            }
        }
        public void SetDailyKitchenEmployee()
        {
            for (int i = 0; i < allEmployees.Count; i++)
            {
                if (allEmployees[i] is KitchenStaff)
                {
                    allEmployeesWorkingToday.Add(allEmployees[i]);
                }
            }
        }
        public void ResetDailyEmployeeStaff()
        {
            allEmployeesWorkingToday.Clear();
        }

        public void CheckIfAreaIsClean(List<string> DaysOfTheWeek)
        {
            for (int i = 0; i < DaysOfTheWeek.Count; i++)
            {
                for (int j = 0; j < allEmployeesWorkingToday.Count; j++)
                {
                    if (allEmployeesWorkingToday[j].hasCleanArea == true)
                    {
                        Console.WriteLine(String.Format("{0} has a clean area on day {1}.", allEmployeesWorkingToday[j], DaysOfTheWeek[i]));
                    }
                    if (allEmployeesWorkingToday[j].hasCleanArea == false)
                    {
                        Console.WriteLine(String.Format("{0} does not have a clean area on day {1}", allEmployeesWorkingToday[j], DaysOfTheWeek[i]));
                    }
                }
            }
        }
    }
}


