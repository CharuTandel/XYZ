namespace MathCode;

public class Xtra
{
    public string Emp_Name { get; set; }
}

public class Encapsulation : Xtra
{
    // Encapsulation provides a controlled way of accessing and modifying the data through methods,
    //  ensuring that the internal implementation details are hidden from the outside world.
    // Keeping the field ID private to prevent direct access from outside the class called encapsulation or Data Hiding 
    private int ID;

    public Encapsulation(int num)
    {
        ID = num;
    }

    public void Encap_Method()
    {
        System.Console.WriteLine(" Encapsulation value passed  " + ID);

        System.Console.WriteLine(" Encapsulation2 Getting/ Returning a value " +Emp_Name);
    


    }
}