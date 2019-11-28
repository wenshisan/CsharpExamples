using System;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入算术运算符");
            string Operator = Console.ReadLine();

            Console.WriteLine("请输入第二个数字");
            int number2 = int.Parse(Console.ReadLine());

            int result = 0;
            switch (Operator)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"运算结果{result}");
            Console.ReadLine();
        }
    }
}
