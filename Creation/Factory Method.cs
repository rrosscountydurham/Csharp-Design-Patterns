using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface Product {
        void GetSelf();
    }

    public abstract class Creator
    {
        public abstract Product factoryMethod();
    }

    public class ConcreteProduct : Product {
        public void GetSelf()
        {
            Console.WriteLine("I am a concrete product");
        }
    }

    public class ConcreteCreator : Creator
    {
        public override Product factoryMethod()
        {
            return new ConcreteProduct();
        }
    }

    public class ConcreteProductTwo : Product
    {
        public void GetSelf()
        {
            Console.WriteLine("I am a concrete product too");
        }
    }

    public class ConcreteCreatorTwo : Creator
    {
        public override Product factoryMethod()
        {
            return new ConcreteProductTwo();
        }
    }
}
