using EmployeeAccounting.Model;

public class BackOfficeEmployee : Employee, IVisitable
{
    public long Bonus { get; set; }
    public BackOfficeEmployee(string name, long salary, long bonus) : base(name, salary)
    {
        Bonus = bonus;
    }

    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
