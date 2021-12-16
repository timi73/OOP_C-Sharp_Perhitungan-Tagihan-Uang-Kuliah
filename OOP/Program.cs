using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "GeeksForGeeks";

            // Finding the index of character 
            // which is present in string and
            // this will show the value 5
            int index1 = str.IndexOf('F');

            Console.WriteLine("The Index Value of character 'F' is " + index1);

            // Now finding the index of that character which
            //  is not even present with the string
            int index2 = str.IndexOf('C');

            // As expected, this will output value -1
            Console.WriteLine("The Index Value of character 'C' is " + index2);
        }
    }
}
