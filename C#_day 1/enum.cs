using System.IO;
using System;
public enum salutation
{
    Mr=0,
    Ms=1,
}
class Program
{
    static void Main()
    {
        salutation salutation;
        string name ;
        Console.WriteLine("Enter ");
        salutation =(salutation)Enum.Parse(typeof(salutation),Console.ReadLine());
        name= Console.ReadLine();
        Console.Write("name is {0}",salutation.ToString());
        Console.Write("."+name);
        
    }
}