using EmployeeSalary;

string[,] employeesArray = new string[,]
{
    {"101","John","SE","10000"},
    {"102","Smith","SE","20000"},
    {"103","Dev","SSE","30000"},
    {"104","Pam","SE","40000"},
    {"105","Sara","SSE","50000"}
};

IEmployeeTarget employeeTarget = new EmployeeAdapter();
employeeTarget.ProcessCompanySalary(employeesArray);