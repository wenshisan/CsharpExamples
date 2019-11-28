using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte Sbyte = 100; //有符号字节型
            byte Byte = 200; //无符号字节型
            char Char = '\u0061'; //字符型
            short Short = 30000; //有符号短整型
            ushort Ushort = 6000; //无符号短整型；
            int Int = 20000000; //无符号整型‘
            uint Uint = 40000000; //有符号整型；
            long Long = 9000000000000000000; //有符号长整型
            ulong ULong = 18000000000000000; //无符号长整型


            Console.Title = "数值类型";
            Console.WriteLine($"有符号字节型\t{Sbyte}");
            Console.WriteLine($"无符号字节型\t{Byte}");
            Console.WriteLine($"字符型\t{Char}");
            Console.WriteLine($"有符号短整型\t{Short}");
            Console.WriteLine($"无符号短整型\t{Ushort}");
            Console.WriteLine($"无符号整型\t{Int}");
            Console.WriteLine($"有符号整型\t{Uint}");
            Console.WriteLine($"有符号长整型\t{Long}");
            Console.WriteLine($"无符号长整型\t{ULong}");
            Console.ReadLine();
        }
    }
}
