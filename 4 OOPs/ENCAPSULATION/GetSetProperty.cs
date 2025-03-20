public class GetSetProperty
{
    private string Name ;


    public string PropertyName      // public DataType PropertyName
    {
         set { Name = value; }     // To set value in Name field

         get { return Name; }      // To get value from Name field
    }

        public void View()
        {
            System.Console.WriteLine($"The private string Name is {Name}");
        }

    
}