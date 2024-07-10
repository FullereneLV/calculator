using System;

namespace HW2_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do { AskNumbers();
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            } while (value == "y" || value == "Y");

        }

        static void AskNumbers()
        {
            Console.WriteLine("Please enter first number");
            var firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            var secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose operation *, /, +, -");
            var operation = Console.ReadLine();
            Console.WriteLine($"Result is {firstNum} {operation} {secondNum}= {Operation(operation, firstNum, secondNum)}");
        }

        static int Operation(string option, int firstNum, int secondNum)
        {
            int result = 0;
            switch (option)
            {
                case "+": result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    result = firstNum / secondNum;
                    break;
            }

            return result;
        }
    }
}
