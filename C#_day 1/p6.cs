using System.IO;
using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5] ;
        int sum = 0 ;
        Console.WriteLine("Enter the elements");
        for(int i = 0 ; i< arr.Length ; i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("The sum of the Array");
        for(int i = 0 ; i< arr.Length ; i++)
        {
            sum = arr[i]+ sum;
           
        }
        Console.WriteLine(sum);
        
       
    }
}