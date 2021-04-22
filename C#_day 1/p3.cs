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
        if(a < 18)
        {
           
           
             Console.WriteLine("Not Eligible for Vote");
                 
        
        }
        else if (a>=60)
        {
          Console.WriteLine("You are a senior citizen");  
        }
        else
        {
            Console.WriteLine("Eligible for vote"); 
        }
       
    } 
}