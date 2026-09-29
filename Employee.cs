namespace Employee;

class Employee
{
    public int Id{get;set;}
    public string Name{get;set;}
    public decimal Salary {get; set;}

    public void ClockIn()
    {
        Console.WriteLine($"{Name} has clocked in.");

    }
    public void ClockOut()
    {
        Console.WriteLine($"{Name} clocked out");
    }
    public Employee(int id, string name, decimal salery)
    {
        Id= id;
        Name=name;
        Salary=salery;

    }
      public virtual void Work()
    {
        Console.WriteLine("Employee is working");
    }
}
class Developer : Employee
{
    public string ProgrammingLanguage {get;set;}
    public Developer(int id,string name,decimal salery,string techStack) : base(id, name, salery)
    {
        ProgrammingLanguage=techStack;
    }
    public override void Work()
    {
        Console.WriteLine($"{Name} is writing code");
    }
}
class Manager : Employee
{
    public int TeamSize {get; set;}

    public Manager(int id,string name,decimal salery,int teamSize):base(id, name, salery)
    {
        TeamSize=teamSize;
    }
    public override void Work()
    {
        Console.WriteLine($"{Name} is leading a team");
    }
}
