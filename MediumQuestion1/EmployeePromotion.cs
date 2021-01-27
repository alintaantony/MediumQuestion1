using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumQuestion1
{
    class EmployeePromotion
    {
        public void EmployeeDetails()
        {
            int input = 1;
            int employeeIdToDisplayEmplyeeObject;
            var employees = new Dictionary<int, Employee>();
            try
            {
                while (input == 1)
                {
                    Employee employeeClassObject = new Employee();
                    employeeClassObject.TakeEmployeeDetailsFromUser();
                    employees.Add(employeeClassObject.Id, employeeClassObject);
                    Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                if (input == 0)
                {
                    Console.WriteLine("Please enter the employee ID");
                    employeeIdToDisplayEmplyeeObject = Convert.ToInt32(Console.ReadLine());
                        if (employees.ContainsKey(employeeIdToDisplayEmplyeeObject))
                        {
                        Console.WriteLine(employees[employeeIdToDisplayEmplyeeObject]);
                        }
                        else
                        {
                        Console.WriteLine("Please Enter the correct Employee Id");

                        }
                }
                else
                {
                    Console.WriteLine("Please Enter 1 or 0 only !! Thank You");
                    EmployeeDetails();
                }
            }catch(Exception e)
            {
                Console.WriteLine("Sorry !! There was an error !! Please Try Again !!");
                Console.WriteLine(e);
                EmployeeDetails();
            }
        }
    }
}
