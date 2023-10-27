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
        public void ArrayNmaps()
        {
            fileLines = File.ReadAllLines(fileDirectory);
            //Since im already adding the file items into the array from the start here im just spliting the string so it reads it as 6 separate items
            for (int i = 0; i < fileLines.Length; i++)
            {
                var fields = fileLines[i].Split(' ');
                Console.WriteLine(fields);
            }


            //adds the items (Value) into the hashtable with also a key 
            for (int i = 0; i < fileLines.Count(); i++)
            {
                Numbers.Add(i, Numbers);
                Console.WriteLine(Numbers);
            }
        }
        //This method 
        public void StackNqueue()
        {
            fileLines = File.ReadAllLines(fileDirectory);
            //adds the file items into the stack
            foreach (string item in fileLines)
            {
                myStack.Push(item);
                //print out the data inside the collection
                Console.WriteLine(item);
            }
            //adds the file items into the queue
            foreach (string item in fileLines)
            {
                qt.Enqueue(item);
                //print out the data inside the collection
                Console.WriteLine(item);
            }
        }
        //this checks if the file is not found, or unable to read a file in that directory
        public void fileMissing()
        {
            if (!File.Exists(fileDirectory))
            {
                Console.WriteLine("File not found. Recheck the file directory");
            }
        }
    }
}

