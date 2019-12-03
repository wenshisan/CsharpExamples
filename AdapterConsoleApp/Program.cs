using System;

namespace AdapterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlant target = new BJOrchard();
            target.Plant();
            target = new SHOrchard();
            target.Plant();

            Console.WriteLine("Hello World!");
        }
    }

    //种植接口
    public interface IPlant
    {
        void Plant();
    }

    public class Orchard
    {
        public void Plant(string city, string fruit)
        {
            Console.WriteLine($"{city}果园种植{fruit}");
        }
    }

    public class BJOrchard:Orchard,IPlant
    {
            public void Plant()
            {
                base.Plant("北京","苹果");
            }
    }

    //对象适配器 上海果园
    public class SHOrchard:IPlant
    {
        Orchard orchard = new Orchard();
        public void Plant()
        {
            orchard.Plant("上海","橙子");
        }
    }
}
