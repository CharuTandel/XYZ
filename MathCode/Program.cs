namespace MathCode;

class Program
{

  //  Main method, is  the entry point for your C# application. The runtime looks for this method to start execution.
  // The Main method is marked as static because it is called by the runtime without needing to create an instance of the Program class.
  public static void Main(string[] args)
  {

    // Console.WriteLine(" Hello !!");
    //  Derived obj = new Derived(" Child object called ");
    //  obj.Mymethod();

    // Derived obj2 = new Derived();
    // obj2.Mymethod();

    //  static Method access in other class then 
    // palindrome.VerifyPalindrome();

    // create an object
    // palindrome obj = new palindrome();
    // obj.VerifyPalindrome();

    // evenodd.EvenMethod();

    // factorial.FactMethod();

    // reversed.Mymethod();

    // fibonacci.fibonacciMethod();

    // prime.primeMethod();

    // Inheritance obj = new Inheritance();
    // obj.ThirdMethod();

    //    single inheritance
    // obj.FirstABC();

    // multi - level   A -> B -> C
    //   obj.FirstABC();
    //   obj.SecondXYZ();
    //   obj.ThirdMethod();

    // Hierarchical inheritance  A-> B  and  A -> C
    //  C obj2 = new C();
    //  obj2.Method_C();
    //  obj2.FirstABC();

    //    multiple inheritance
    // obj2.oneinterface();
    // obj2.Two_MethodInterface();
    // obj2.FirstABC();

    // Abstraction class/ method

    // DerivedAbstract obj = new DerivedAbstract();
    // obj.Method1();
    // obj.Method2();

    //  Interface object
    // InterfaceType obj2 = new InterfaceType();
    // obj2.First_Method();
    // System.Console.WriteLine(obj2.Two_Method());
    // obj2.Another_Method();


    //  Encapsulation Example
    // Encapsulation obj2 = new Encapsulation(33);
    // obj2.Emp_Name = "Vanshika Mital";
    // obj2.Encap_Method();
    // obj2.Emp_Name ="lavanya";
    // System.Console.WriteLine(" Getting/ Returning a value " + obj2.Emp_Name);

    // Word- Palindrome
    // WordPalindrome.LetterPalindrome();


    // Method overloading - Polymorphism
    // Polymorphism.Addition(5, 44);

    // System.Console.WriteLine(Polymorphism.Addition(2, 4, 6));

    // System.Console.WriteLine(Polymorphism.Addition(2.3, 4.6, 2.3));

    // Polymorphism.Addition(6);

    // System.Console.WriteLine(Polymorphism.Addition(6, 4.4, 5));

    // System.Console.WriteLine(Polymorphism.Addition("Hello  ", "Lavanya"));
    // System.Console.WriteLine(Polymorphism.Addition("123  ", "45678"));


    //   Method - OVERRIDE polymorphism

    // MethodOverriding Base_Obj;

    // Base_Obj = new First_Derived();
    // Base_Obj.DisplayName();

    // Base_Obj = new Two_Derived();
    // Base_Obj.DisplayName();

    // Base_Obj = new Third_Derived();
    // Base_Obj.DisplayName();


    // Base_Obj = new MethodOverriding();
    // Base_Obj.DisplayName();


  }
}
