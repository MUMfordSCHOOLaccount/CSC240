using System;
using static System.Console;

class ExceptionsOnPurpose
{
    static void Main()
    {
        int answer;
        int result;
        int zero = 0;

        try
        {
            Write("Enter an integer >> ");
            answer = Convert.ToInt32(ReadLine());
            result = answer / zero; // will throw DivideByZeroException when executed
            WriteLine("The answer is " + answer);
        }
        catch (FormatException ex)
        {
            WriteLine("Input was not in a correct format: " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            WriteLine("Attempted to divide by zero: " + ex.Message);
        }
        catch (Exception ex)
        {
            WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
