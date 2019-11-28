using System;

namespace ExchangeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数字1");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入数字2");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("交换数值");
            Exchange(ref num1,ref num2);
            Console.WriteLine($"交换后为{nameof(num1)}:{num1},{nameof(num2)}:{num2}");
            Console.ReadKey();
        }

        /// <summary>
        /// 将两个数的值进行交换
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        static void Exchange(ref int number1, ref int number2)
        {
            int temp = number2;
            number2 = number1;
            number1 = temp;
        }
    }
}
