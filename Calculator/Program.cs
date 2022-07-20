using CalculatorProgram;

namespace CalculatorProgram // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            bool endApp = false;
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {

                string num1 = "";
                string num2 = "";
                double result = 0;

                Console.WriteLine("Enter the first number:");
                num1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(num1, out cleanNum1))
                {
                    Console.WriteLine("This is not a valid number, please enter a valid number:");
                    num1 = Console.ReadLine();
                }

                Console.WriteLine("Enter the second number:");
                num2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(num2, out cleanNum2))
                {
                    Console.WriteLine("This is not a valid number, please enter a valid number:");
                    num2 = Console.ReadLine();
                }

                string operand = calculator.RequestOp();

                try
                {
                    result = calculator.Operate(cleanNum1, cleanNum2, operand);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will fail");
                    }
                    else Console.WriteLine($"Your result is: {result}\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to do another calculation: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");

            }
        }

    }
}