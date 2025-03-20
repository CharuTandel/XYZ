
public class EncapsulationClass
{
    //  cannot directly access from outside class - Data hide inside class 
    private int num1;

    // To set number using method

    public void SetNum(int value)
    {
        num1 = value;
    }


    //  to Get Number
    public int GetNum()
    {
        return num1;
    }

    public void Display()
    {
        System.Console.WriteLine(" Display Method called " + num1);
    }

}