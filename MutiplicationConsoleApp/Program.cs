using System;

namespace MutiplicationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] intparmes = new int[] { };

            Console.WriteLine("请输入第一个数");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入第二个数");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入第三个数");
            int num3 = int.Parse(Console.ReadLine());

            int result;
            GetMultResult(out result, num1, num2, num3);

            
            Console.WriteLine($"{num1},{num2},{num3}的乘积是{result}");
        }

        /// <summary>
        /// 求多个整数的乘积
        /// </summary>
        /// <param name="result">多个整数的乘积</param>
        /// <param name="numbers">需要求乘积的整数集合</param>
        public static void GetMultResult(out int result, params int[] numbers)
        {
            result = 1;
            foreach (int number in numbers)
            {
                result *= number;
            }
        }
    }
}
