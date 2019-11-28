using System;

namespace ReferenceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle() { Redius = 100 };
            Column column1 = new Column() { Heightt = 20, Circle = circle1 };
            Console.WriteLine($"圆柱体1高度{column1.Heightt}");
            Console.WriteLine($"圆柱体1底面半径{column1.Circle.Redius}");

            Console.WriteLine("将圆柱体1赋值给圆柱体2");

            Column column2 = column1;

            Console.WriteLine("将圆柱体1半径改为30");

            circle1.Redius = 30;

            Console.WriteLine($"圆柱体1的底面半径{column1.Circle.Redius}");
            Console.WriteLine($"圆柱体2的底面半径{column2.Circle.Redius}");

            Console.WriteLine($"圆柱体1的高度{column1.Heightt}");
            Console.WriteLine($"圆柱体2的高度{column2.Heightt}");

            Console.WriteLine("将圆柱体2的高度改为40");

            column2.Heightt = 40;

            Console.WriteLine($"圆柱体1的高度{column1.Heightt}");
            Console.WriteLine($"圆柱体2的高度{column2.Heightt}");

            Console.ReadLine();

        }
    }

    /// <summary>
    /// 圆柱体
    /// </summary>
    struct Column
    {
        /// <summary>
        /// 圆柱体高度
        /// </summary>
        public int Heightt;

        /// <summary>
        /// 圆形
        /// </summary>
        public Circle Circle;
    }

    /// <summary>
    /// 圆形类
    /// </summary>
    class Circle
    {
        /// <summary>
        /// 圆形半径
        /// </summary>
        public int Redius { get; set; } 
    }
}
