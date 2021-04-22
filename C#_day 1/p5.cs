using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter What you want to do \n 1.Add \n 2.Sub \n 3.mul");
        int a = Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
            case 1 :
               Console.WriteLine("You choose +");
               break ;
            case 2 :
               Console.WriteLine("You choose -");
               break ;
            case 3 :
               Console.WriteLine("You choose *");
               break ; 
            default :
               Console.WriteLine("Wrong selection");
               break ;   
        }
    }
}