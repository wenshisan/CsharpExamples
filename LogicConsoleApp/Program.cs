using System;

namespace LogicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}的十六进制形式为0x{1:x8}",Number,Number);

            //当一个int与0xFF按位与(&)运算后，得到就是第一个字节
            int NumberHex = Number & 0x000000FF;
            Console.WriteLine("第一个字节为：0x{0:x2}", NumberHex);

            //int型有4个字节，每个字节占二进制位数8位，往右移动(>>)8位后高位以0或1补齐，低位舍弃，本来的第二个字节变为第一字节
            NumberHex = Number >> 8 & 0x000000FF;
            Console.WriteLine("第二个字节为：0x{0:x2}", NumberHex);

            //第三个字节
            NumberHex = Number >> 16 & 0x000000FF;
            Console.WriteLine("第三个字节为：0x{0:x2}", NumberHex);

            //第四个字节
            NumberHex = Number >> 24 & 0x000000FF;
            Console.WriteLine("第四个字节为：0x{0:x2}", NumberHex);

            Console.ReadKey();
        }
    }
}
