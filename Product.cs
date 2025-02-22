namespace RecordCsharp;

public class Product
{
    public readonly int id = 100000;
    private string Color;

    public const string Size = "Larg";

    public string Name { get; set; }
    public int Price { get; set; }
    public int Count { get; set; }

    private int _age;

    public int Age {get;set;}
}

public class Setting
{
    public const string ApplicationName = "Vira Shop";
}
