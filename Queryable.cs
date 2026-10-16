namespace Queryable;
public class Employeequery
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Salary { get; set; }

    public Employeequery(int id, string name, decimal salary)
    {
        Id=id;
        Name=name;
        Salary=salary;
    }
}