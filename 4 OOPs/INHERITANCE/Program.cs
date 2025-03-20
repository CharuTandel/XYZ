namespace INHERITANCE;

class Program
{
    static void Main(string[] args)
    {

        // Child obj = new Child();
        // obj.ChildMethod();
        // obj.MethodSingle();

        // ChildC obj = new ChildC();

        // obj.ChildCMethod();
        // obj.ChildBMethod();
        // obj.MethodMultilevel();

        // ChildB X = new ChildB();
        // X.ChildBMethod();
        // X.MethodMultilevel();

        // Multilevel A = new Multilevel();
        // A.MethodMultilevel();

        // Child_C  obj = new Child_C();
        // obj.ChildC_Meth();
        // obj.Method_Hierarchical();

        // Child_B obj2 = new Child_B();
        // obj2.Meth_ChildB();
        // obj2.Method_Hierarchical();

        // Derived obj = new Derived();
        // obj.C();
        // obj.B();
        // obj.A();
        // obj.Next();

        D obj = new D();
        obj.D_Method();
        obj.C_Method();
        
        obj.B1_Method();
        obj.Method_Hybrid();
    }
}
