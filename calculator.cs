using System;

class Calculator
{
    static void Main(string[] args)
    {
        double num1, num2;
        char operation;
        
        // Ask user for input number-1
        Console.WriteLine("Enter first number:");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a number:");
        }
       
       // Ask user for input number-2
        Console.WriteLine("Enter second number:");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a number:");
        }

        Console.WriteLine("Enter operation (+, -, *, /):");
        while (!char.TryParse(Console.ReadLine(), out operation) || 
               (operation != '+' && operation != '-' && operation != '*' && operation != '/'))
        {
            Console.WriteLine("Invalid input. Please enter a valid operation (+, -, *, /):");
        }

        switch (operation)
        {
            case '+':
                Console.WriteLine("Result: " + (num1 + num2));
                break;

            case '-':
                Console.WriteLine("Result: " + (num1 - num2));
                break;

            case '*':
                Console.WriteLine("Result: " + (num1 * num2));
                break;

            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                else
                {
                    Console.WriteLine("Result: " + (num1 / num2));
                }
                break;

            default:
                Console.WriteLine("Invalid operation");
                break;
        }
    }
}
