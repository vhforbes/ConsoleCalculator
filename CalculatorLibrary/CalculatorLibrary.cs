using System.IO;
using System.Diagnostics;

namespace CalculatorProgram
{
    public class Calculator
    {
        // Constructor
        public Calculator()
        {
            StreamWriter logFile = File.CreateText("calculator.log");
            Trace.Listeners.Add(new TextWriterTraceListener(logFile));
            Trace.AutoFlush = true;
            Trace.WriteLine("Starting calculator log");
            Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
        }
        public double Operate(double num1, double num2, string operand)
        {
            double result = double.NaN;

            switch (operand)
            {
                case "+":
                    result = num1 + num2;
                    Trace.WriteLine(String.Format("{0} + {1} = {2}", num1, num2, result));
                    break;
                case "-":
                    result = num1 - num2;
                    Trace.WriteLine(String.Format("{0} - {1} = {2}", num1, num2, result));
                    break;
                case "*":
                    result = num1 * num2;
                    Trace.WriteLine(String.Format("{0} * {1} = {2}", num1, num2, result));
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Trace.WriteLine(String.Format("{0} / {1} = {2}", num1, num2, result));
                    }
                    break;
                default:
                    break;
            }

            return result;
        }

        public string RequestOp()
        {
            string operand = "";
            bool validOperand = false;

            while (!validOperand)
            {
                if (operand == "+" || operand == "-" || operand == "*" || operand == "/")
                {
                    validOperand = true;
                }
                else
                {

                    Console.WriteLine("Choose an operator from the following list:");
                    Console.WriteLine("+ : Add");
                    Console.WriteLine("- : Subtract");
                    Console.WriteLine("* : Multiply");
                    Console.WriteLine("/ : - Divide");
                    Console.Write("\nYour option?\n");

                    operand = Console.ReadLine();
                }


            }

            return operand;
        }
    }
}