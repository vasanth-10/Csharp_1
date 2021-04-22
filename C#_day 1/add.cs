using System.IO;

using System;


class Program

{
    
static void Main(string[]  args)
    
{
       
int firstnumber , secondnumber , result ;
       
Console.WriteLine("Enter 1st number");
       
firstnumber =Convert.ToInt32(Console.ReadLine());
       
Console.WriteLine("Enter 2nd number");
       
secondnumber =Convert.ToInt32(Console.ReadLine());
       
result = firstnumber + secondnumber ;
       
Console.WriteLine("Result"+result);
       
Console.WriteLine();
      
 Console.ReadLine();
    
}

}