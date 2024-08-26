//Example of Try-Catch Block:

//try
//{
//    // Code that might throw an exception
//}
//catch (ExceptionType1 ex)
//{
//    // Code to handle ExceptionType1
//}
//catch (ExceptionType2 ex)
//{
//    // Code to handle ExceptionType2
//}
//finally
//{
//    // Code that always runs, regardless of exceptions
//}

using System;
using System.IO;



// Question 1
// Write a C# program that attempts to divide two numbers and prints any exceptions that may occur.
// Hint: Use a try block to perform the division and a catch block to print any exceptions.
// Test Data: Dividing 10 by 0
// class program{

//     static void Main(){

//         try
//         {

//             int numerator = 10;
//             int denominator = 0;

//             int result = numerator / denominator;
//             Console.WriteLine($"Result is: {result}");
//         }
//         catch (DivideException ex)
//         {
            
//             Console.WriteLine($"Error: {ex.Message}");
//         }

//     }
// }


// Question 2
// Create a program that converts a string to an integer and prints any exceptions that may occur.
// Hint: Use a try block to convert the string to an integer and a catch block to print any exceptions.
// Test Data: Converting 'abc' to an integer

// class program{

//     static void Main(){

//         try
//         {

//             string alphaBet = "abc";
//             int result = int.Parse(alphaBet);
//             Console.WriteLine($"Result is: {result}");
//         }
//         catch (Exception ex)
//         {
            
//             Console.WriteLine($"Error: {ex.Message}");
//         }

//     }
// }


// Question 3
// Write a C# program that opens a file and prints any exceptions that may occur.
// Hint: Use a try block to open the file and a catch block to print any exceptions.
// Test Data: Opening a non-existent file

// class program{

//     static void Main(){

//         try
//         {

//             string fileBath = "nonexistent.txt";

//             using(StreamReader reader = new StreamReader(fileBath)){
//                  Console.WriteLine("File opened successfully!");

//             }

//         }
//         catch (Exception ex)
//         {
            
//             Console.WriteLine($"Error: {ex.Message}");
//         }

//     }
// }

// Question 4
// Create a program that reads input from the user and prints any exceptions that may occur.
// Hint: Use a try block to read input from the user and a catch block to print any exceptions.
// Test Data: Reading input from the user

// class program{

//     static void Main(){

//         try
//         {

//             Console.Write("Enter anything: ");

//             string input = Console.ReadLine();

//             Console.WriteLine($"Your entred: {input}");

//         }
//         catch (Exception ex)
//         {
            
//             Console.WriteLine($"Error: {ex.Message}");
//         }

//     }
// }


// Question 5
// Write a C# program that performs a calculation and prints any exceptions that may occur.
// Hint: Use a try block to perform the calculation and a catch block to print any exceptions.
// Test Data: Performing a calculation with invalid operands

class program{

    static void Main(){

        try
        {

            Console.Write("Enter first number: ");

            string input1 = Console.ReadLine();

            Console.Write("Enter second number: ");

            string input2 = Console.ReadLine();

            Console.Write("Enter operation(+, -, x, :): ");

            string input3 = Console.ReadLine();

            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);

            int result = 0;

            switch (input3)
            {
                case "+":
                result = num1 + num2;
                break;
                     case "-":
                result = num1 - num2;
                break;
                     case "x":
                result = num1 * num2;
                break;
                     case "/":
                result = num1 / num2;
                break;
                default:
                Console.WriteLine("This calculation is not available or is not within the program limits");
                break;
            }

            Console.WriteLine($"Result of calculated: {result}");

        }
        catch (Exception ex)
        {
            
            Console.WriteLine($"Error: {ex.Message}");
        }

    }
}