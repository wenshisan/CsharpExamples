using System;

//抽象工厂模式
namespace AbstractFactoryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OrChard bjoOrchard = new BJOrChard();
            Apple bjapple = bjoOrchard.CreateApple();
            bjapple.PlanApple();
            
        }
    }

    //苹果园抽象类
    abstract class OrChard
    {
        public abstract Apple CreateApple();
        public abstract Orange CreateOrange();
    }

    //北京果园抽象类
    class BJOrChard : OrChard
    {
        public override Apple CreateApple()
        {
            return new BJApple();
        }

        public override Orange CreateOrange()
        {
            return new BJOrange();
        }
    }

    //上海果园类
    class SHOrchard : OrChard
    {
        public override Apple CreateApple()
        {
            return new SHApple();
        }

        public override Orange CreateOrange()
        {
            return new SHOrange();
        }
    }

    //苹果抽象类
    abstract class Apple
    {
        public abstract void PlanApple();
    }

    //北京苹果类
    class BJApple : Apple
    {
        public override void PlanApple()
        {
            Console.WriteLine("种植北京苹果");
        }
    }

    //上海苹果类
    class SHApple : Apple
    {
        public override void PlanApple()
        {
            Console.WriteLine("种植上海水果");
        }
    }

    //橘子抽象类
    abstract class Orange
    {
        public abstract void PlantOrange();
    }

    //上海橘子类
    class SHOrange : Orange
    {
        public override void PlantOrange()
        {
            Console.WriteLine("种植了上海橘子");
        }
    }

    //北京橘子类
    class BJOrange : Orange
    {
        public override void PlantOrange()
        {
            Console.WriteLine("种植了北京橘子");
        }
    }
}
