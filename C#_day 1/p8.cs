using System.IO;
using System;

class Program
{
    public int num{get;set;}
    public int name{get;set;}
    public int gender{get;set;}
    
    static void Main()
    {
        Program Program = new Program();
        Program.num= 2;
        Program.name= "Vasanth" ;
        Console.WriteLine(Program.num +"\t"+Program.name);
    }
}