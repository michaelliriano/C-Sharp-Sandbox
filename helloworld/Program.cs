using System;
using helloworld.Math;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Console Calculator!");
            Console.WriteLine("Please select from the following: +, -, *, /");
            var method = Console.ReadLine();
            if(method == "+")
            {
                Console.WriteLine("What is the first number to add?");
                var floatValueOne = float.Parse(Console.ReadLine());
                Console.WriteLine("What is the second number to add?");
                var floatValueTwo = float.Parse(Console.ReadLine());
                var answer = calculator.Add(floatValueOne, floatValueTwo);
                Console.WriteLine("The answer is " + answer);
            }
            else if(method == "-")
            {
                Console.WriteLine("What is the first number to subtract?");
                var floatValueOne = float.Parse(Console.ReadLine());
                Console.WriteLine("What is the second number to subtract?");
                var floatValueTwo = float.Parse(Console.ReadLine());
                var answer = calculator.Subtract(floatValueOne, floatValueTwo);
                Console.WriteLine("The answer is " + answer);
            }
            else if (method == "*")
            {
                Console.WriteLine("What is the first number to multiply?");
                var floatValueOne = float.Parse(Console.ReadLine());
                Console.WriteLine("What is the second number to multiply?");
                var floatValueTwo = float.Parse(Console.ReadLine());
                var answer = calculator.Multiply(floatValueOne, floatValueTwo);
                Console.WriteLine("The answer is " + answer);
            }
            else if (method == "/")
            {
                Console.WriteLine("What is the first number to div?");
                var floatValueOne = float.Parse(Console.ReadLine());
                Console.WriteLine("What is the second number to multiply?");
                var floatValueTwo = float.Parse(Console.ReadLine());
                var answer = calculator.Divide(floatValueOne, floatValueTwo);
                Console.WriteLine("The answer is " + answer);
            }
            else
            {
                Console.WriteLine("Incorrect command try again.");
            }

        }
    }
}
