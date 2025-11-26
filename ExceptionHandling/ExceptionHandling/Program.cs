using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Remoting.Channels;
using System.Text;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console App Strings and Integers

            try  // Try catch/Exception Handling
            {
                Console.WriteLine("Pick a number. "); //Ask the user to pick a number.
                int numberOne = Convert.ToInt32(Console.ReadLine()); // convert nnuber to integer
                Console.WriteLine("Pick a second number. "); //Ask the user to pick a second number
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Divide the two...");  //Divide both numbers
                int numberThree = numberOne / numberTwo; 
                Console.WriteLine(numberOne + "\ndivided by " + numberTwo + "equals " + numberThree);
                Console.ReadLine(); //Display result

            }
            catch ( FormatException ex ) //Exception format
            {
                Console.WriteLine("Please type a whole number."); //Asking for input number
                return; // Display Output
            }
            catch (DivideByZeroException) //Handling zero exception formatting
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally // Read and display output
            {
                Console.ReadLine();   
            }
            //End the program


            //Creating a list of an integers.
            List<int> intList = new List<int>() { 10, 20, 15, 120, 69, 5, 150, 780 };
            //Asking the users for a number to divide each number in the list by, and loop through the integer list above to select input.
            bool validNum = false;
            while (validNum) // This loop takes each integer in the the list, divides it by the number the user entered and displays the result to the screen. 
            {
                //Using try/catch block to give error message
                try
                { 
                
                    Console.WriteLine("\nEnter a number to divide: ");
                    float divideNum = float.Parse(Console.ReadLine());
                    //If statement, this check if the user input is 0.
                    if (divideNum == 0)
                    {
                        Console.WriteLine("Please enter number other than 0. ");
                    }
                    //Dividing each number in the list by the input figure
                    else
                    {
                        foreach (int num in intList)
                        {
                            float Divide = num / divideNum;
                            Console.WriteLine(num + "/" + divideNum + " = " + Divide);
                        }
                    }
                    validNum = true;


                }
                //catch block and display error message for string input
                catch (FormatException)
                {
                    Console.WriteLine("Input not valid. Please enter a valid number. ");
                }
            }
            //This is a message to let the user know the programe has exited the try/catch block
            Console.WriteLine("This program has exited the try/catch block.");
        }
    }
}