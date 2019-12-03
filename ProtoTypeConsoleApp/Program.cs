using System;

namespace ProtoTypeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OrChard bjOrchard = new OrChard();
            bjOrchard.Name = "北京";
            bjOrchard.Apple = "北京苹果";
            bjOrchard.Orange = "北京橙子";
            bjOrchard.Plant();

            //种植上海果园
            OrChard shOrchard = bjOrchard.Clone() as OrChard;
            shOrchard.Name = "上海";
            shOrchard.Plant();

            Console.WriteLine("Hello World!");
        }
    }

    //创建一个果园接口
    public interface IOrchard
    {
        IOrchard Clone();
    }

    //创建果园类
  public  class OrChard : IOrchard
    {
        public string Name { get; set; } //果园名
        public string Apple { get; set; } //苹果
        public string Orange { get; set; } //橙子
        public IOrchard Clone()
        {
            return new OrChard()
            {
                Name = this.Name,
                Apple = this.Apple,
                Orange = this.Orange
            };
        }

        public void Plant()
        {
            Console.WriteLine($"{this.Name}果园种植了{this.Apple}和{this.Orange}");
        }
    }
}
