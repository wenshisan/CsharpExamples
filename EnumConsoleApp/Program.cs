using System;

namespace EnumConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = Animal.Cat;
            switch (animal)
            {
                case Animal.Cat:
                    Console.WriteLine("猫");
                    break;
                case Animal.Dog:
                    Console.WriteLine("狗");
                    break;
                case Animal.Mouse:
                    Console.WriteLine("鼠");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }

    enum Animal:byte
    {
        Cat = 0,
        Dog = 1,
        Mouse = 2
    }
}
