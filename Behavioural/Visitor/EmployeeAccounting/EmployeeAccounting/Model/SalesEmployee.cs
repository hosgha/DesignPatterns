using EmployeeAccounting.Model;

public class SalesEmployee : Employee, IVisitable
{
    public long Commission { get; set; }
    public SalesEmployee(string name, long salary, long commission) : base(name, salary)
    {
        Commission = commission;
    }

    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
