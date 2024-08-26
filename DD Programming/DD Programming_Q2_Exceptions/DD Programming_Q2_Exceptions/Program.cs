
// Guide to Exceptions in C#:

// System.ArgumentNullException:
// - Thrown when a null argument is passed to a method that does not accept null arguments.

// System.FormatException:
// - Thrown when a method is called with an invalid format for its input arguments.

// System.IndexOutOfRangeException:
// - Thrown when an attempt is made to access an element of an array or collection with an index outside the bounds.

// System.InvalidCastException:
// - Thrown when an invalid type conversion is attempted.

// System.IO.IOException:
// - Thrown when an I/O error occurs, such as when reading from or writing to a file.

// System.DivideByZeroException:
// - Thrown when attempting to divide an integer or decimal number by zero.

// System.NullReferenceException:
// - Thrown when attempting to access a member of a null object reference.

// System.OverflowException:
// - Thrown when an arithmetic operation results in an overflow.

// System.NotImplementedException:
// - Thrown when a method or feature is not yet implemented.

// System.OutOfMemoryException:
// - Thrown when attempting to allocate memory fails due to insufficient available memory.

// System.StackOverflowException:
// - Thrown when the execution stack overflows, typically due to excessive recursion.

// System.TimeoutException:
// - Thrown when an operation times out before completing.

// System.ArgumentException:
// - Thrown when one or more arguments provided to a method are invalid or out of range.

// System.ArithmeticException:
// - Thrown for errors in arithmetic operations.

// System.Security.SecurityException:
// - Thrown when a security violation occurs, such as attempting to perform an operation that requires elevated permissions.


using System;
using System.IO;

//Part 1
//Write a C# program that prompts the user to input two numbers and divides them. Handle an exception when the user enters non-numeric values.
//Hint: Use the TryParse method to convert the input string to a number.
//Hint:Use FormatException for non-numeric values and DivideByZeroException for division by zero.
// class program
// {

//     static void Main()
//     {
//         Console.WriteLine("Enter two number to numerator: ");
//         string input1 = Console.ReadLine();
//         Console.WriteLine("Enter two number to denominator: ");
//         string input2 = Console.ReadLine();

//         double numerator;
//         double denominator;

//         try
//         {
//             if (double.TryParse(input1, out numerator) && double.TryParse(input2, out denominator))
//             {
//                 if (denominator != 0)
//                 {
//                     double result = numerator / denominator;
//                     Console.WriteLine($"Result is: {result}");
//                 }
//                 else
//                 {
//                     throw new DivideByZeroException("Cannot divide by zero!");
//                 }

//             }
//             else
//             {
//                 throw new FormatException("Invalid input!");
//             }

//         }
//         catch (DivideByZeroException ex)
//         {

//             Console.WriteLine(ex.Message);
//         }
//         catch (FormatException ex)
//         {
//             Console.WriteLine(ex.Message);
//         }

//     }

// }


//Part 2
// Write a C# program that reads a string from the user and converts it to an integer. Handle the exception if the input cannot be parsed into an integer.
//Hint: Use the TryParse method to convert the input string to an integer.
//Hint: Use FormatException for invalid input.

// class Program{
//     static void Main(){
//         try
//         {
//             Console.Write("Enter string to convert to integer: ");
//             string input = Console.ReadLine();
//             int integerNum;

//             if(int.TryParse(input, out integerNum)){
//                 Console.WriteLine($"Integer is: {integerNum}");
//             }else{
//                 throw new FormatException("Invalid input!");
//             }


//         }
//         catch (FormatException ex)
//         {
            
//             Console.WriteLine(ex.Message);
//         }
//     }
// }


//Part 3
//Write a C# program that implements a method that divides two numbers. Handle the DivideByZeroException that occurs if the denominator is 0.
//Hint: Use a try-catch block to catch the DivideByZeroException.

// class Program{
//     static void Main(){
//         try
//         {
            
//             int numerator = 10;
//             int denominator = 5;

//             int result = numerator / denominator;
//             Console.WriteLine($"Result is: {result}");

//         }
//         catch (DivideByZeroException ex)
//         {
            
//             Console.WriteLine($"Error: {ex.Message}");
//         }
//     }
// }

//Part 4
//Write a C# program that creates a method that takes a string as input and converts it to uppercase. Handle the NullReferenceException that occurs if the input string is null.
//Hint: Use a try-catch block to catch the NullReferenceException.


class Program{
    static void Main(){
        try
        {
            
            Console.Write("Enter string to uppercase: ");
            string input = Console.ReadLine();

            
            if(!String.IsNullOrEmpty(input)){
                
                Console.WriteLine($"Result is: {input.ToUpper()}");
            }else{
                throw new NullReferenceException("The input string is null!");
            }

    
        }
        catch (NullReferenceException ex)
        {
            
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}