using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class A
    {
        public abstract void FuncA1();
        public abstract void FuncA2();
    }

    public class A1 : A
    {
        public A1(string arguement)
        {
            Console.WriteLine("Hello " + arguement);
        }
        public override void FuncA1()
        {
            Console.WriteLine("This is function A1 in object A1");
        }

        public override void FuncA2()
        {
            Console.WriteLine("This is function A2 in object A1");
        }
    }

    public class A2 : A
    {
        public A2(string arguement)
        {
            Console.WriteLine("Hello " + arguement);
        }
        public override void FuncA1()
        {
            Console.WriteLine("This is function A1 in object A2");
        }

        public override void FuncA2()
        {
            Console.WriteLine("This is function A2 in object A2");
        }
    }

    public abstract class B
    {
        public abstract void FuncA1();
        public abstract void FuncA2();
    }

    public class B1 : B
    {
        public B1(string arguement)
        {
            Console.WriteLine("Hello " + arguement);
        }
        public override void FuncA1()
        {
            Console.WriteLine("This is function A1 in object B1");
        }

        public override void FuncA2()
        {
            Console.WriteLine("This is function A2 in object B1");
        }
    }

    public class B2 : B
    {
        public B2(string arguement)
        {
            Console.WriteLine("Hello " + arguement);
        }
        public override void FuncA1()
        {
            Console.WriteLine("This is function A1 in object B2");
        }

        public override void FuncA2()
        {
            Console.WriteLine("This is function A2 in object B2");
        }
    }

    public abstract class AbsFactory
    {
        public abstract A createA();
        public abstract B createB();
    }

    public class ConcreteFactory1 : AbsFactory
    {
        public override A createA()
        {
            return new A1("A1");
        }

        public override B createB()
        {
            return new B1("B1");
        }
    }

    public class ConcreteFactory2 : AbsFactory
    {
        public override A createA()
        {
            return new A2("A2");
        }

        public override B createB()
        {
            return new B2("B2");
        }
    }

    public class FactoryMaker
    {
        private static AbsFactory pf = null;

        public static AbsFactory getFactory(string choice)
        {
            switch (choice)
            {
                case "1": pf = new ConcreteFactory1(); break;
                case "2": pf = new ConcreteFactory2(); break;
                default: break;
            }
            return pf;
        }
    }
}
