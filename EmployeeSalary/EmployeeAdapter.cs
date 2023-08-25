using EmployeeSalary;
using System;
using System.Xml.Linq;

public class EmployeeAdapter : ThirdPartyBillingSystem, IEmployeeTarget
{
    public void ProcessCompanySalary(string[,] employeesArray)
    {
        string? Id = null;
        string? Name = null;
        string? Designation = null;
        string? Salary = null;

        List<Employee> employeeList = new List<Employee>();

        for (int i = 0; i < employeesArray.GetLength(0); i++)
        {
            for (int j = 0; j < employeesArray.GetLength(1); j++)
            {
                if (j == 0)
                {
                    Id = employeesArray[i, j];
                }
                else if (j == 1)
                {
                    Name = employeesArray[i, j];
                }
                else if (j == 2)
                {
                    Designation = employeesArray[i, j];
                }
                else
                {
                    Salary = employeesArray[i, j];
                }
            }

            employeeList.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
        }

        ProcessCompanySalary(employeeList);
    }
}
