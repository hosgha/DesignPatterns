namespace EmployeeSalary
{
    public class Employee
    {
        public Employee(int iD, string? name, string? designation, decimal salary)
        {
            ID = iD;
            Name = name;
            Designation = designation;
            Salary = salary;
        }

        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Designation { get; set; }
        public decimal Salary { get; set; }
    }
}
