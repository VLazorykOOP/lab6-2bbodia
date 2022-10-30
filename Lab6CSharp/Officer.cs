class Officer : Employee
{
    public Officer(string name, string surname, int age, int salary, Guid signNumber)
        : base(name, surname, age, salary)
    {
        Console.WriteLine("Officer constructor");
        SignNumber = signNumber;
    }
    public Officer(string name, string surname, int age, int salary) : this(name, surname, age, salary, Guid.NewGuid())
    {
    }
    public Officer(string name, string surname, int age) : this(name, surname, age, 20000)
    {
    }
    private Officer(Officer other)
    {
        (Name, Surname, Age, Salary, SignNumber) = other;
    }
    public void Deconstruct(out string name, out string surname, out int age, out int salary, out Guid signNumber)
    {
        base.Deconstruct(out name, out surname, out age, out salary);
        signNumber = SignNumber;
    }

    ~Officer()
    {
        Console.WriteLine($"Officer {Name} {Surname} destructor");
    }

    public Guid SignNumber { get; set; }

    public override string ShowInfo()
    {
        return base.ShowInfo() + $", SignNumber: {SignNumber}";
    }
    public override object Clone()
    {
        return new Officer(this);
    }


}