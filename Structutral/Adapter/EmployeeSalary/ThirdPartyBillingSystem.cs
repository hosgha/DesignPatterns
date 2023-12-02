using EmployeeSalary;
// Adaptee
public class ThirdPartyBillingSystem
{
    public void ProcessCompanySalary(List<Employee> employees) 
    {
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"{employee.Name} {employee.Designation} => {employee.Salary}");
        }
    }
}
