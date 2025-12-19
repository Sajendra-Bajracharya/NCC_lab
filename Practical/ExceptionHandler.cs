using System;

class ExceptionHandler
{
    static void Main()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int denominator = int.Parse(Console.ReadLine());

            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid integers.");
        }
        finally
        {
            Console.WriteLine("Program execution completed.");
        }
    }
}
