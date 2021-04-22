using System.IO;
using System;

class Program
{
    static void Main()
    {
        int a;
         Console.WriteLine("Enter the age"); 
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        if(a>=18)
        {
          Console.WriteLine("Eligible for Vote");
        }
        else
        {
          Console.WriteLine("Not Eligible for Vote");  
        }
    } 
}