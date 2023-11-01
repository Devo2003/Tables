using System;
using System.Collections;

namespace HashTables
{
	public class hashVSarray
	{


        public string lines;
        public string fileDirectory;
        public string[] fileLines;
        public Hashtable Numbers = new Hashtable();
        public Stack<string> myStack = new Stack<string>();
        public Queue qt = new Queue();

        public hashVSarray()
		{
            //this line gives in the path of the file into a string
            fileDirectory = "/Users/devinsalgado35/Desktop/HashTables/HashTables/Nums.txt";
        }
        public void ArrayExample()
        {
            fileLines = File.ReadAllLines(fileDirectory);
            //adds the file items into the array
            foreach (string line in fileLines)
            {
                Console.WriteLine(line);
            }

        }

        public void MapsExample()
        {
            //adds the file items into the Hashtable
            foreach (string Numbers in fileLines)
            {

                Console.WriteLine(Numbers);
            }
        }
        public void StackExample()
        {
            fileLines = File.ReadAllLines(fileDirectory);
            //adds the file items into the stack
            foreach (string item in fileLines)
            {
                myStack.Push(item);
                Console.WriteLine(item);
            }

        }
        public void QueueExample()
        {
            //adds the file items into the queue
            foreach (string item in fileLines)
            {
                qt.Enqueue(item);
                Console.WriteLine(qt);
            }
        }

        //this checks if the file is not found, or unable to read a file in that directory
        public void fileMissing()
        {
            if (!File.Exists(fileDirectory))
            {
                Console.WriteLine("File not found");
            }
        }
    }
}

