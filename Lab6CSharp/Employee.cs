using Lab6CSharp;

class Employee : Person, IEmployable
{
    public Employee(string name, string surname, int age, int salary) : base(name, surname, age)
    {
        Console.WriteLine("Employee constructor");
        Salary = salary;
    }
    public Employee(string name, string surname, int age) : this(name, surname, age, 6500) { }
    public Employee(string name, string surname) : this(name, surname, 18) { }
    private Employee(Employee other) 
    {
        (Name, Surname, Age, Salary) = other;
    }
    protected Employee() { Salary = 0; }
    ~Employee()
    {
        Console.WriteLine($"Employee {Name} {Surname} destructor");
    }
    public int Salary { get; set; }

    public override string ShowInfo()
    {
        return base.ShowInfo() + $", Salary: {Salary}";
    }
    public void Deconstruct(out string name, out string surname, out int age, out int salary)
    {
        base.Deconstruct(out name, out surname, out age);
        salary = Salary;
    }
    public void DoWork()
    {
        Console.WriteLine($"{this.GetType().Name} {Name} {Surname} is working");
    }
    public override object Clone()
    {
        return new Employee(this);
    }
}