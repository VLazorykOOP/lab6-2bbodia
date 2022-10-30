class Engineer : Employee
{
    public Engineer(string name, string surname, int age, int salary, int experience) :
        base(name, surname, age, salary)
    {
        Console.WriteLine("Engineer constructor");
        Experience = experience;
    }
    public Engineer(string name, string surname, int age, int salary) : this(name, surname, age, salary, 0)
    {
    }
    public Engineer(string name, string surname, int age) : this(name, surname, age, 10000)
    {
    }
    private Engineer(Engineer other)
    {
        (Name, Surname, Age, Salary, Experience) = other;
    }
    public void Deconstruct(out string name, out string surname, out int age, out int salary, out int experience)
    {
        base.Deconstruct(out name, out surname, out age, out salary);
        experience = Experience;
    }
    public override object Clone()
    {
        return new Engineer(this);
    }
    ~Engineer()
    {
        Console.WriteLine($"Engineer {Name} {Surname} destructor");
    }
    public int Experience { get; set; }

    public override string ShowInfo()
    {
        return base.ShowInfo() + $", Experience: {Experience}";
    }
    public IEnumerator<object> GetEnumerator()
    {
        yield return Name;
        yield return Surname;
        yield return Age;
        yield return Salary;
        yield return Experience;
        yield break;
    }
}