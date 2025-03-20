namespace MathCode;

public class Baseclass 
{

     public Baseclass()
     {
          System.Console.WriteLine(" Default base constructor");
     }
       
       static Baseclass()
       {
          System.Console.WriteLine("Static base class constructor automatically once called before first instance created");
       }


     public  Baseclass(string newname)
     {
          System.Console.WriteLine(" Base class parameterized " + newname);
     }


}
