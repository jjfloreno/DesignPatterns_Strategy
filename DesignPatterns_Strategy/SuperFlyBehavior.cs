using System;
namespace DesignPatterns_Strategy
{
    public class SuperFlyBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Some custom logic here because this duck is flying with a cape");
        }
    }
}
