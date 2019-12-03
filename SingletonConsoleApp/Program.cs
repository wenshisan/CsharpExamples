using System;

namespace SingletonConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Helicopter helicopter = Helicopter.Instance;
            helicopter.SprayInsecticide("上海");
            helicopter.SprayInsecticide("北京");
            Console.WriteLine("Hello World!");
        }
    }

    public class Helicopter
    {
        static Helicopter helicopter;

        public static Helicopter Instance
        {
            get
            {
                if (helicopter == null)
                {
                    helicopter = new Helicopter();
                }
                return helicopter;
            }
        }

        //直升机受保护的构造方法
        protected Helicopter()
        {


        }
        int insecticide = 100; //杀虫剂

        //为指定城市喷洒杀虫剂
        public void SprayInsecticide(string city)
        {
            insecticide -= 50;
            Console.WriteLine($"为{city}果园喷洒农药");

            if (insecticide == 0)
            {
                Console.WriteLine("杀虫剂已用完！");
            }
            else
            {
                Console.WriteLine($"杀虫剂还剩{insecticide}吨");
            }
        }
    }
}
