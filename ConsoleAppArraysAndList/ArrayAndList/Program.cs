using System;
using System.Collections.Generic;

namespace ArrayAndList
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating a one-dimensional Array of strings
            string[] stringArray = { "Apple", "Banana", "Cherry", "Orange", "Strawberry", "Mango", "Carrot" };

            // Displaying the string Array
            Console.WriteLine("String Array:");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine($"Index {i}: {stringArray[i]}");
            }

            //Ask the user to select an index of the string Array
            Console.WriteLine("Enter an index for the string Array: ");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            //To Check if the index is within the bounds of the Array
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                // Display the string at the selected Index
                Console.WriteLine($"string at Index {stringIndex}: {stringArray[stringIndex]}");

            }
            else
            {
                //Display message if the Index is out of bounds
                Console.WriteLine("Index is out of bounds.");
            }

            //Creating a One-dimentional Array of integers
            int[] intArray = { 11, 12, 13, 14, 15 };

            //Display the above integer array:
            Console.WriteLine("\nInteger Array:");
            for (int i = 0; i < intArray.Length; i++)
                {
                Console.WriteLine($"Index {i}: {intArray[i]}");
                }
            //Ask the user to select an index of the integer Array
            Console.WriteLine("Enter an index for the integer Array: ");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            //Check if the Index is within the bounds of the Array
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                Console.WriteLine($"Integer at index {intIndex}: {intArray[intIndex]}");
            }
            else
            {
                //Display the message if the index is out bounds
                Console.WriteLine("Index is out of bounds.");
            }

            // Creating a list of strings
            List<string> stringList = new List<string> 
            { "Black", "Red", "White", "Green", "Blue", "Yellow", "Purple" };

            //Display the list of strings
            Console.WriteLine("\nString List: ");

            for (int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine($"Index {i}: {stringList[i]}");
            }

            //Ask the user to select an index of the string List
            Console.WriteLine("Enter an index for the string list: ");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            //Check if index is within the bounds of the list
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                // Display the string at the selected index
                Console.WriteLine($"String at selected index {listIndex}: {stringList[listIndex]}");
            }
            else
            {
                //Display a message if the index is out of bounds.
                Console.WriteLine("Index is out of bounds.");
            }

            //List<string> stringList = new List<string>();
            //intList.Add("Hello");
            //intList.Add("Victor");
            //intList.Remove("Victor");

            //Console.WriteLine(intList[1]);
            //Console.ReadLine();


            //int[] numArray = new int[5];
            //numArray[0] = 6;
            //numArray[1] = 10;
            //numArray[2] = 15;
            //numArray[3] = 2500;
            //numArray[4] = 100;

            ////This is to insert new number into an array
            //int[] numArray1 = new int[] { 25, 10, 15, 2500, 100, 460 };
            //int[] numArray2 =  { 5, 11, 400, 70, 100, 2400, };

            //numArray2[5] = 140;

            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();
        }
    }    
}
