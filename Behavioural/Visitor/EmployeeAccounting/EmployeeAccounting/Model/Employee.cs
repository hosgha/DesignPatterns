public class Employee 
{
    public string Name { get; set; }
    public long Salary { get; set; }
    public Employee(string name, long salary)
    {
        Name = name;
        Salary = salary;
    }
}
