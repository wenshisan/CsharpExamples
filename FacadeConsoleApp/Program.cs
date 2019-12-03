using System;

namespace FacadeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Plant plant = new Plant();
            plant.PlantAppleOrange();
            plant.PlantOrangeBanana();
            Console.WriteLine("Hello World!");
        }
    }

    //苹果类
    public class Apple
    {
        public void PlantApple()
        {
            Console.WriteLine("种植苹果树");
        }
    }

    //橙子类
    public class Orange
    {
        public void PlantOrange()
        {
            Console.WriteLine("种植橙子树");
        }
    }

    //香蕉类
    public class Banana
    {
        public void PlantBanana()
        {
            Console.WriteLine("种植香蕉树");
        }
    }

    //创建种植类
    public class Plant
    {
        Apple apple = new Apple();
        Orange orange = new Orange();
        Banana banana = new Banana();

        public void PlantAppleOrange()
        {
            Console.WriteLine("--北京果园--");
            apple.PlantApple();
            orange.PlantOrange();
        }

        public void PlantOrangeBanana()
        {
            Console.WriteLine("--上海果园--");
            orange.PlantOrange();
            banana.PlantBanana();
        }
    }
}
