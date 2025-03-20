
public class VirtualClass
{

     //  the VIRTUAL method of Base_Class Can be override/modified in derived class with new implementation 
     //  Not Compulsory to Modify the Virtual Method in Derived class .You can also use virtual method as it is .   
   

    public virtual void MethodVirtual()              // VIRTUAL Method 
    {
        System.Console.WriteLine(" virtual Method of base class");
    }


    public void Concrete()
    {
        System.Console.WriteLine(" Concrete Method ");
    }

}

public class ChildNew : VirtualClass
{
    // No virtual Method are  Modified / override here
    
}


public class Child3 : VirtualClass
{
    public override void MethodVirtual()               // Virtual method is modified/ overriden
    {
        System.Console.WriteLine("Modified  Virtual method of Child ");
        
    }
}

