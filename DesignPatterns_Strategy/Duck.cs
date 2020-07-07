using System;
namespace DesignPatterns_Strategy
{
    public class Duck : IDuck
    {
        public Duck(string name, IFlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
            DuckType = name;
        }

        public string DuckType { get ; set ; }
        public IFlyBehavior FlyBehavior { get ; set ; }

        public void DuckDuckGo()
        {
            Console.WriteLine($"Hi, I am a {DuckType} Duck!");
            FlyBehavior.Fly();
            Quack();
        }

        public void Quack()
        {
            Console.WriteLine("Quack!!!");
        }
    }
}
