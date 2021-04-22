using System.IO;
using System;

class Program
{
    static void Main()
    {
        int[,] arr = new int[2,2] ;
        
        Console.WriteLine("Enter the elements");
        for(int i=0 ; i< arr.GetLength(0) ; i++)
        {
            for(int j = 0 ; j< arr.GetLength(1) ; j++)
            {
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        
        }
        Console.WriteLine("Matrix");
          for(int i = 0 ; i< arr.GetLength(0) ; i++)
        {
            for(int j = 0 ; j< arr.GetLength(1) ; j++)
            {
                Console.Write(arr[i,j]+"\t");
             
            }
             Console.WriteLine("\n");
              
        
        }
         Console.WriteLine(" Transpose of the Matrix");
         for(int i = 0 ; i< arr.GetLength(0) ; i++)
        {
            for(int j = 0 ; j< arr.GetLength(1) ; j++)
            {
                Console.Write(arr[j,i]+"\t");
            }
            Console.WriteLine("\n");
        
        }
        
       
       
    }
}