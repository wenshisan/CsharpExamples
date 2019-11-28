using System;

namespace FactorialConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字");
            decimal dc = decimal.Parse(Console.ReadLine());


            Console.WriteLine($"{dc}的阶乘是{factorial(dc)}");
            Console.ReadKey();
        }

        /// <summary>
        /// 返回一个数的阶乘，阶乘指一个数与等于或小于自身的所有数的乘积
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static decimal factorial(decimal n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * (n - 1);
            }
        }
    }
}
