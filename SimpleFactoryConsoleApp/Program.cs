using System;

namespace SimpleFactoryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Orchard orchard = new Orchard();
            Fruit apple = orchard.Create("苹果");
            apple.Plant();
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 果园
    /// </summary>
    class Orchard
    {
        public Fruit Create(string FruitName)
        {
            switch (FruitName)
            {
                case "苹果":
                    return new Apple();
                    break;
                case "橙子":
                    return new Orange();
                    break;
                default:
                    throw new Exception("水果名称错误");
            }
        }
    }
    class Apple : Fruit
    {
        public override void Plant()
        {
            Console.WriteLine("种植苹果");
        }
    }

    class Orange : Fruit
    {
        public override void Plant()
        {
            Console.WriteLine("种植橙子");
        }
    }
    abstract class Fruit
    {
        public abstract void Plant();
    }
}
