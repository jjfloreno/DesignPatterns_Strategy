using System;
namespace DesignPatterns_Strategy
{
    public interface IDuck
    {
        public string DuckType { get; set; }

        IFlyBehavior FlyBehavior { get; set; }

        void Quack();

        void DuckDuckGo();
    }
}
