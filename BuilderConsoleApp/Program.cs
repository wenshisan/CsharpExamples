using System;

//建造者模式
namespace BuilderConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建北京果园建造指导者
            OrchardDirector bjOrchardDirector = new OrchardDirector(new BJOrchardBuilder());
            Orchard bjOrchard = bjOrchardDirector.Construct();
            bjOrchard.Plant();

            //创建上海果园建造指导者
            OrchardDirector shOrchardDirector = new OrchardDirector(new SHOrchardBuilder());
            Orchard shOrchard = shOrchardDirector.Construct();
            shOrchard.Plant();
            Console.WriteLine("Hello World!");
        }
    }

    //果园类
   public  class Orchard
    {
        string Name; //果园名
        public string Apple { get; set; }
        public string Orange { get; set; }

        //构造函数
        public Orchard(string name)
        {
            this.Name = name;
            Console.WriteLine("建造{0}果园", Name);
        }

        public void Plant()
        {
            Console.WriteLine("{0}果园种植{1}和{2}", Name, Apple, Orange);
        }
    }

    //果园建造者
  public  abstract class OrchardBuilder
    {
        public abstract void BuildApple();
        public abstract void BuildOrange();
        public abstract Orchard GetOrchard();
    }

    //北京果园建造者
    public class BJOrchardBuilder : OrchardBuilder
    {
        Orchard bjOrchard = new Orchard("北京果园");
        public override void BuildApple()
        {
            bjOrchard.Apple = "北京苹果";
        }

        public override void BuildOrange()
        {
            bjOrchard.Orange = "北京橙子";
        }
        public override Orchard GetOrchard()
        {
            return bjOrchard;
        }
    }

    //上海果园建造者
    class SHOrchardBuilder : OrchardBuilder
    {
        Orchard shOrchardBuilder = new Orchard("上海");
        public override void BuildApple()
        {
            shOrchardBuilder.Apple = "上海苹果";
        }

        public override void BuildOrange()
        {
            shOrchardBuilder.Orange = "上海橙子";
        }

        public override Orchard GetOrchard()
        {
            return shOrchardBuilder;
        }
    }

    //果园建造指导者
    public class OrchardDirector
    {
        OrchardBuilder orchardBuilder;
        public OrchardDirector(OrchardBuilder myOrchardBuilder)
        {
            this.orchardBuilder = myOrchardBuilder; //为果园创造者赋值
        }

        public Orchard Construct()
        {
            orchardBuilder.BuildApple(); //创建苹果
            orchardBuilder.BuildOrange(); //创建橙子
            return orchardBuilder.GetOrchard(); //返回果园实例
        }
    }
}
