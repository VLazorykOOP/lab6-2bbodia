using Lab6CSharp;

void Task1()
{
    List<IShowable> people = new List<IShowable>
    {
       new Person("Bohdan", "Bandura", 19),
    new Employee("Nazar", "Boiko", 25, 10000),
   new Officer("Vasia", "Chmut", 30, 15000, Guid.NewGuid()),
    new Engineer("Dmytro", "Tusk", 40, 2000, 10)
};

    foreach (var pers in people)
    {
        Console.WriteLine($"{pers.GetType().Name}    {pers.ShowInfo()}");
    }
}
void Task2()
{
    List<IFunction> functions = new List<IFunction>
{
 new Line(1,2),
    new Quadratic(1,2,3),
    new Hyperbola(5)
};
    double x = 4;
    foreach (var func in functions)
    {
        Console.WriteLine(func);
        Console.WriteLine($"X = {x}");
        Console.WriteLine($"Y = {func.Calculate(x)}");
    }
}
void Task3()
{
    Engineer engineer = new Engineer("Bob", "Chuck", 25, 155000, 5);
    foreach (var item in engineer)
    {
        Console.WriteLine(item);
    }
}

Task1();
GC.Collect();
Thread.Sleep(2000);
Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();
Task2();
Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();
Task3();




