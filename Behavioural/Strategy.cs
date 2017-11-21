using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class StrategyBase
    {
        public abstract void CreateFruit();
    }

    public class StrategyFruitMaker
    {
        public StrategyBase strategy;

        public void CallStrategy()
        {
            strategy.CreateFruit();
        }
    }

    public class StrategyBanana : StrategyBase
    {
        public override void CreateFruit()
        {
            Console.WriteLine("I have made a banana");
        }
    }

    public class StrategyApple : StrategyBase
    {
        public override void CreateFruit()
        {
            Console.WriteLine("I have made an apple");
        }
    }
}
