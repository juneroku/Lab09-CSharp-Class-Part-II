public static class Person
{
    public static string name = ""; // หรือ public static string? name; ถ้าต้องการยอมรับค่า null

    public static string GetName()
    {
        return $"Hello from {name}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person.name = "Natthanan"; // กำหนดค่าให้ Person.name
        System.Console.WriteLine(Person.GetName());
    }
}