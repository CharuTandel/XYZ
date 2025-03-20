namespace KEYWORD;
class Program
{

    static void Main(string[] args)

    {
        // ReadOnlyClass obj1 = new ReadOnlyClass(6);
        // ReadOnlyClass obj2 = new ReadOnlyClass(4);
        // ReadOnlyClass obj3 = new ReadOnlyClass(45);

        // System.Console.WriteLine("Enter integer value here ");
        // int pass = Convert.ToInt32(Console.ReadLine());

        // ReadOnlyClass obj1 = new ReadOnlyClass(pass);


        // obj1.Method1();
        // System.Console.WriteLine(obj1.detail);
        // obj1.detail = 234;


        // obj2.Method1();
        // System.Console.WriteLine(obj2.detail);

        // ConstantClass obj = new ConstantClass();

        // obj.MethodConst();

        // System.Console.WriteLine(ConstantClass.num);

        // CHILD obj = new CHILD();
        // obj.ChildMethod();

        // obj.BaseMethod();

        // Child1 obj = new Child1();
        // obj.AMethod1();
        // obj.ConcreteMethod();

        // Child3 obj = new Child3();
        // obj.MethodVirtual();
        // obj.Concrete();

        // ChildNew obj1 = new ChildNew();
        // obj1.MethodVirtual();
        // obj1.Concrete();

        // Child4 obj1 = new Child4();
        // obj1.BaseVirtual();
        // obj1.AbsMethod();

        // Child2 obj2 = new Child2();
        // obj2.BaseVirtual();
        // obj2.AbsMethod();


        // StaticClass.Fieldname = 45;
        // StaticClass.Method1();


        // StaticClass obj = new StaticClass();

        // StaticClass vari ;

        // obj.Method2();


        // obj.Fieldname = 66;
        // obj.Method1();

        SealedClass obj = new SealedClass();
        obj.ABC_Method();
        obj.Digit = 22;
        // SealedClass.Digit= 23;
        obj.ABC_Method();

        // obj.MethodVirtual();

        // ChildX obj = new ChildX();
        // obj.MethodX();

        // ChildX.Fieldname = 45;
        // ChildX.Method1();
    }
}
