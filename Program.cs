using System;

namespace HW2_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number");
            var firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            var secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter operation");
            var operation = Console.ReadLine();
            Console.WriteLine($"Result is {firstNum} {operation} {secondNum}: {Operation(operation, firstNum, secondNum)}");
        }

        static int Operation(string option, int firstNum, int secondNum)
        {
            if (option == "+") { return firstNum + secondNum; }
            else if (option == "/")
            {
                return firstNum / secondNum;

            }
            else if (option == "*")
            {
                return firstNum * secondNum;
            }
            else
            {
                return firstNum - secondNum;
            }
        }
    }
}
