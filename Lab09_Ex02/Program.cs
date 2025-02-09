public static class Person
{
    public static string? name;  

    public static string GetName()
    {
        return $"Hello from {name}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person.name = "Natthanan"; // Assign a value to Person.name
        System.Console.WriteLine(Person.GetName());
    }
}