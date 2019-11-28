using System;

namespace ConditionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入第二个数字");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入第三个数字");
            int num3 = int.Parse(Console.ReadLine());

            //条件运算符是右结合的运算符
            // 即从右向左计算
            int max = num1 > num3 ? num1 > num2 ? num1 : num2 : num3 > num2 ? num3 : num2;
            Console.WriteLine($"{num1},{num2},{num3}中最大的是{max}");
            Console.ReadKey();
        }
    }
}
