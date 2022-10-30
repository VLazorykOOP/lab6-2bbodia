using Lab6CSharp;

class Person : IComparable<Person>, ICloneable, IShowable
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public Person(string name, string surname, int age)
    {
        Console.WriteLine("Person constructor");
        Name = name;
        Surname = surname;
        Age = age;
    }
    public Person(string name, string surname) : this(name, surname, 18)
    {
    }
    public Person(string name) : this(name, string.Empty, 18)
    {
    }
    protected Person() :this(string.Empty){  }
    private Person(Person other)
    {
        (Name, Surname, Age) = other;
    }
    
    public void Deconstruct(out string name, out string surname, out int age)
    {
        name = Name;
        surname = Surname;
        age = Age;
    }

    ~Person()
    {
        Console.WriteLine($"Person {Name} {Surname} destructor");
    }

    public virtual string ShowInfo()
    {
        return $"Name: {Name}, Surname: {Surname}, Age: {Age}";
    }
    public int CompareTo(Person? other)
    {
        ArgumentNullException.ThrowIfNull(other);
        return Age.CompareTo(other.Age);
    }

    public virtual object Clone()
    {
        return new Person(this);
    }
}
