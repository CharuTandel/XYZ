namespace ENCAPSULATION;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Using Get - Set to update a private field
        GetSetProperty obj1 = new GetSetProperty();
        obj1.PropertyName = "Tisca Roy";
        System.Console.WriteLine($"Get/Return the Name  {obj1.PropertyName}");
        obj1.View();

        obj1.PropertyName = "Banku";
        obj1.View();

        
        // Through Methods Controlled Access
        EncapsulationClass obj = new EncapsulationClass();

        obj.SetNum(45);
       System.Console.WriteLine($"Get the Number  {obj.GetNum()}");
        obj.Display();
    }
}
