using System;
using static System.Console;

namespace HashTables 
{
    public class Program
    {
        static void Main()
        {
            hashVSarray hs = new hashVSarray();
            hs.fileMissing();
            hs.ArrayExample();
            hs.MapsExample();
            hs.StackExample();
            hs.QueueExample();
            
      
            Console.ReadKey();
            
        }
    }
}

