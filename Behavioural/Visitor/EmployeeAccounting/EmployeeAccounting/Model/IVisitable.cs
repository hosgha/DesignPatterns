namespace EmployeeAccounting.Model;

public interface IVisitable
{
    void Accept(IVisitor visitor);
}
