using System;

namespace RectangleAreaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("请输入矩形高度");
            rectangle.Height = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入矩形宽度");
            rectangle.Width = int.Parse(Console.ReadLine());

            Console.WriteLine($"矩形面积为{rectangle.Area()}");

            Console.ReadLine();
        }
    }

    /// <summary>
    /// 矩形类，包含计算矩形面积的方法
    /// </summary>
    class Rectangle
    {
        public int Width, Height;

        /// <summary>
        /// 直接返回矩形面积
        /// </summary>
        /// <returns></returns>
        public int Area()
        {
            return Width * Height;
        }

        public int TryArea()
        {
            checked
            {
                int area = Width * Height;
                return area;
            }
        }

    }
}
