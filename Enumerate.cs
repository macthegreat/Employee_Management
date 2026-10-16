namespace Enumerates;
public class EmployeeI
{
    public string Name{get;set;}
    public decimal Salary{get;set;}


    public EmployeeI(string name, decimal salary)
    {
        Name=name;
        Salary=salary;
    }
}