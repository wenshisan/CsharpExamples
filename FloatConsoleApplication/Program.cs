using System;

namespace FloatConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            float Float = 123.456789F; //单精度浮点型
            double Double = 123.456789123456789d; //双精度浮点型
            decimal Decimal = 123.456789123456789m; //高精度浮点型

            Console.Title = "浮点型";
            Console.WriteLine($"单精度浮点型\t{Float}");
            Console.WriteLine($"双精度浮点型\t{Double}");
            Console.WriteLine($"高精度浮点型\t{Decimal}");
            Console.WriteLine("Hello World!");
        }
    }
}
