using System;

namespace Calculator
{
    public class Calculator
    {
        // Create a simple calculator application which reads the parameters from the prompt
        // and prints the result to the prompt.
        // It should support the following operations,
        // reate a method named "Calculate()":
        // +, -, *, /, % and it should support two operands.
        // The format of the expressions must be: {operation} {operand} {operand}.
        // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

        // You can use the Scanner class
        // It should work like this:

        // Start the program
        // It prints: "Please type in the expression:"
        // Waits for the user input
        // Print the result to the prompt
        // Exit

        public static void Main(string[] args)
        {
            Console.WriteLine("Please type in the expression: ");
            string yourInput = Console.ReadLine();

            Console.WriteLine(Calculate(yourInput));

            Console.ReadLine();
        }
        public static string Calculate(string yourInput)
        {
            string[] splitInput = yourInput.Split(' ');
            string myOperator = splitInput[0];
            int firstNumber = Int32.Parse(splitInput[1]);
            int secondNumbeer = Int32.Parse(splitInput[2]);

            if (myOperator == "+")
            {
                int mySolution = firstNumber + secondNumbeer;
                return "Your solution is " + mySolution;
            }
            else if (myOperator == "-")
            {
                int mySolution = firstNumber - secondNumbeer;
                return "Your solution is " + mySolution;
            }
            else if (myOperator == "*")
            {
                int mySolution = firstNumber * secondNumbeer;
                return "Your solution is " + mySolution;
            }
            else if (myOperator == "/")
            {
                int mySolution = firstNumber / secondNumbeer;
                return "Your solution is " + mySolution;
            }
            else if (myOperator == "%")
            {
                int mySolution = firstNumber % secondNumbeer;
                return "Your solution is " + mySolution;
            }
            else
            {
                return "Please specify your input!";
            }
        }
    }
}