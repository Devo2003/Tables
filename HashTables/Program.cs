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
            hs.StackNqueue();
            hs.ArrayNmaps();
      
            Console.ReadKey();
            
        }
    }
}

