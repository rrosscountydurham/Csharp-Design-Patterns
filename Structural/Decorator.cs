using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class DecoratorFruit
    {
        protected string name;

        public virtual void ShowSelf()
        {
            Console.WriteLine("I am a " + name);
        }
    }

    public class DecoratorBanana : DecoratorFruit
    {
        public DecoratorBanana()
        {
            name = "Banana";
        }
    }

    public class DecoratorApple : DecoratorFruit
    {
        public DecoratorApple()
        {
            name = "Apple";
        }
    }

    public abstract class Decorator : DecoratorFruit
    {
        protected DecoratorFruit dFruit;

        public Decorator(DecoratorFruit dFruit)
        {
            this.dFruit = dFruit;
        }
        public override void ShowSelf()
        {
            dFruit.ShowSelf();
        }
    } 

    public class YellowFruit : Decorator
    {
        public YellowFruit(DecoratorFruit dFruit) : base(dFruit) { }

        public override void ShowSelf()
        {
            base.ShowSelf();
            Console.WriteLine("I am also yellow");
        }
    }
}
