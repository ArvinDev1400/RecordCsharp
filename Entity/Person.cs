namespace RecordCsharp.Entity;

public class Person
{
    public string Name { get; set; }
    public string Family { get; set; }
    public int Age { get; set; }

    public void TestWithoutParameter()
    {
        Console.WriteLine("Write test method");
    }

    public void WriteFullName()
    {
        Console.WriteLine($"Name: {Name} - Family: {Family}");
    }
}
