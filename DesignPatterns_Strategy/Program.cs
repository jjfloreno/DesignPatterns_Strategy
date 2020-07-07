using System;
using System.Collections.Generic;

namespace DesignPatterns_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var duckList = new List<Duck>
            {
                new Duck("Mountain", new SuperFlyBehavior()),
                new Duck("Simple", new SimpleFlyBehavior()),
                new Duck("Robot", new RobotFlyBehavior("carbon fiber"))
            };

            foreach (var duck in duckList)
            {
                duck.DuckDuckGo();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
