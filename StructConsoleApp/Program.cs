using System;

namespace StructConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle() { Width = 200, Hight = 300 };
            Console.WriteLine($"是正方形？{rectangle.IsSquare()}");
            Console.ReadLine();
        }
    }

    public struct Rectangle
    {
        public int Width;
        public int Hight;
        public bool IsSquare()
        {
            return Width == Hight;
        }
    }
}
