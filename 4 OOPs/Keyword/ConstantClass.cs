

public  class ConstantClass
{
    // public  int[] Y = {1,2,4,5};

    public  const int num = 11;   // const field never change ,it value assigned only once. its Mandatory to assign a value to const field

    // public ConstantClass (int value)
    // {
    //     num = value;
    // }

    
    public void MethodConst()
    {
        System.Console.WriteLine(" This is const Method " + num);
        // num = 45;
        System.Console.WriteLine(num);
    }


}