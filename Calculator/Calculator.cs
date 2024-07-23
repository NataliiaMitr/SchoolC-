using System;

namespace Calculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This calculator can perfom such actions:");
            Console.WriteLine(@"test
test2");
            Console.WriteLine("1 - addition");
            Console.WriteLine("2 - substraction");
            Console.WriteLine("3 - multiplication");
            Console.WriteLine("4 - division");
            Console.WriteLine("5 - exit from calculator");
            Console.WriteLine();

            Console.WriteLine("Enter your option:");
            string action = Console.ReadLine();
            

                Console.Clear();

                Console.WriteLine("Enter first number:");
                int firstNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                int secondNum = int.Parse(Console.ReadLine());
                double result = 0;


                switch (action)
                {
                    case "1":
                        result = firstNum + secondNum;
                        break;
                    case "2":
                        result = firstNum - secondNum;
                        break;
                    case "3":
                        result = firstNum * secondNum;
                        break;
                    case "4":
                        if (secondNum != 0)
                        {
                            result = firstNum / secondNum;
                        }

                        else

                        {
                            Console.WriteLine("Division by zero is impossible.");

                        }
                        break;
                }

                Console.WriteLine($"Result: {result}");




            

        }
    }
}



