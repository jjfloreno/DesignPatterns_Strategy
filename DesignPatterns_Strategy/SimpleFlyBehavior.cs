using System;
namespace DesignPatterns_Strategy
{
    public class SimpleFlyBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Just a simple algorithm to fly here");
        }
    }
}
