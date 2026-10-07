namespace EmployeeAb;

abstract class EmployeeAbs
{
    public int Id {get; set;}
    public string Name {get; set;}
    public decimal BaseSalary {get; set;}

    public EmployeeAbs(int id, string name, decimal baseSalary)
    {
        Id = id;
        Name = name;
        BaseSalary = baseSalary;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Base Salary: {BaseSalary}");
    }
    public abstract decimal CalculateSalary();

}

class Dev : EmployeeAbs
{
    public Dev(int id, string name, decimal baseSalary) : base(id,name,baseSalary)
    {
        
    }
    public override decimal CalculateSalary()
    {
        return BaseSalary + (BaseSalary * 0.20m);
    }
}

class Managers : EmployeeAbs
{
    public Managers(int id , string name, decimal baseSalary) : base(id, name ,baseSalary)
    {
        
    }
    public override decimal CalculateSalary()
    {
        return BaseSalary + (BaseSalary * 0.05m);
    }
}
class SalesPerson : EmployeeAbs
{
    public decimal SalesAmount {get; set;}
    public SalesPerson(int id , string name, decimal baseSalary, decimal salesAmount) : base(id, name, baseSalary)
    {
        SalesAmount = salesAmount;
    }
    public override decimal CalculateSalary()
    {
        return BaseSalary + (SalesAmount * 0.10m);
    }
}