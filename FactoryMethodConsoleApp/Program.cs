using System;

namespace FactoryMethodConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AppleOrchard appleOrchard = new AppleOrchard();
            Fruit apple = appleOrchard.Create();

            apple.Plant();

            Console.WriteLine("Hello World!");
        }
    }

    abstract class Orchard
    {
        public abstract Fruit Create();
    }

    class AppleOrchard : Orchard
    {
        public override Fruit Create()
        {
            return new Apple();
        }
    }

    abstract class Fruit
    {
        public abstract void Plant();
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

    class Bannana : Fruit
    {
        public override void Plant()
        {
            Console.WriteLine("种植香蕉");
        }
    }
}
