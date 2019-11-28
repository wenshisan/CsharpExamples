using System;

namespace CircleAreaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Console.WriteLine($"圆面积{circle.Area()}");
            Console.ReadLine();
        }
    }

    /// <summary>
    /// 圆形类
    /// </summary>
    class Circle
    {
        public const double Pi = 3.1415926f; //圆周率

        public readonly double Redius = 1;

        /// <summary>
        /// 将传入的半径赋值给计算半径
        /// </summary>
        /// <param name="redius"></param>
        public Circle(double redius)
        {
            Redius = redius;
        }

        /// <summary>
        /// 计算圆形面积
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            return Redius * Pi;
        }

    }
}
