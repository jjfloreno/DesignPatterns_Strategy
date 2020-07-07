using System;
namespace DesignPatterns_Strategy
{
    public class RobotFlyBehavior : IFlyBehavior
    {
        private string _duckMaterial { get; set; }

        public RobotFlyBehavior(string material)
        {
            _duckMaterial = material;
        }

        public void Fly()
        {
            Console.WriteLine("Another concrete algorithm for a robot duck");
            Console.WriteLine($"This duck is flying with {_duckMaterial} wings!");
        }
    }
}
