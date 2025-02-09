public static class Person
{
    public static string? name;

    public static string GetName()
    {
        return $"Hello from {name}";
    }
}

public class Student // ลบ : Person ออก
{
    public string? name; // เพิ่มฟิลด์ name ให้กับ Student

    public string GetName() // เพิ่มเมธอด GetName ให้กับ Student
    {
        return $"Hello from {name}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person.name = "Person";
        System.Console.WriteLine(Person.GetName());

        var student = new Student();
        student.name = "Student";
        System.Console.WriteLine(student.GetName());
    }
}