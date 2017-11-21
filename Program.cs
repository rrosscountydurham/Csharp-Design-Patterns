using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory();
            FactoryMethod();
            Builder();
            Prototype();
            Singleton();

            Adapter();
            Bridge();
            Composite();
            Decorator();
            Facade();
            Flyweight();
            Proxy();

            ChainOfResponsibility();
            Command();
            Interpreter();
            Mediator();
            Memento();
            Observer();
            State();
            Strategy();
            Template();
            Visitor();

            Console.ReadLine();
        }

        public static void AbstractFactory()
        {
            Console.WriteLine("Abstract Factory \n");
            AbsFactory One = FactoryMaker.getFactory("1");
            A A1 = One.createA();
            A1.FuncA1();
            A1.FuncA2();
            AbsFactory Two = FactoryMaker.getFactory("2");
            B B2 = Two.createB();
            B2.FuncA1();
            B2.FuncA2();
            Console.WriteLine();
        }

        public static void FactoryMethod()
        {
            Console.WriteLine("Factory Method \n");
            Creator Concrete = new ConcreteCreator();
            Product prod = Concrete.factoryMethod();
            prod.GetSelf();
            Concrete = new ConcreteCreatorTwo();
            prod = Concrete.factoryMethod();
            prod.GetSelf();
            Console.WriteLine();
        }

        public static void Builder()
        {
            Console.WriteLine("Builder \n");
            Builder builder = new ConcreteBuilderOne();
            builder.MakePartA(); builder.MakePartB();
            BuilderProduct bProduct = builder.GetResult();
            bProduct.Show();
            builder = new ConcreteBuilderTwo();
            builder.MakePartA();
            bProduct = builder.GetResult();
            bProduct.Show();
        }

        public static void Prototype()
        {
            Console.WriteLine("Prototype \n");
            ConcretePrototype cp = new ConcretePrototype("Betty");
            Prototype proto = cp.CloneSelf();
            proto.Nameself();
            Prototype proto2 = cp.CloneSelf();
            proto2.Nameself();
            proto2.ChangeName("Yeti");
            proto.Nameself();
            proto2.Nameself();
            Console.WriteLine();
        }

        public static void Singleton()
        {
            Console.WriteLine("Singleton \n");
            SingletonType s1 = SingletonType.Instance();
            SingletonType s2 = SingletonType.Instance();

            s1.Nameself();
            SingletonType.myName = "Jerry";
            s2.Nameself();
            Console.WriteLine();
        }

        public static void Adapter()
        {
            Console.WriteLine("Adapter \n");
            OldRectangle oldRect = new OldRectangle(0, 0, 100, 100);
            oldRect.DisplayArea();
            NewRectangle newRect = new NewRectangle(0,0,200,200);
            newRect.CalculateArea();
            newRect = new NewRectangle(oldRect);
            newRect.CalculateArea();
            Console.WriteLine();
        }

        public static void Bridge()
        {
            Console.WriteLine("Bridge \n");
            BridgeFruit bFruit;
            BridgeObject bObj = new BridgeObject(new ImplementationOne());
            bObj.DoProduct();
            bFruit = bObj.GetFruit();
            bFruit.PrintSelf();
            bObj = new BridgeObject(new ImplementationTwo());
            bObj.DoProduct();
            bFruit = bObj.GetFruit();
            bFruit.PrintSelf();
            Console.WriteLine();
        }

        public static void Composite()
        {
            Console.WriteLine("Composite \n");
            Branch trunk = new Branch("trunk");
            Branch branchone = new Branch("east branch");
            Branch branchtwo = new Branch("west branch");
            trunk.Add(branchone);
            trunk.Add(branchtwo);
            branchone.Add(new Leaf("east leaf"));
            branchtwo.Add(new Leaf("west leaf"));
            Leaf leaf = new Leaf("branch leaf");
            leaf.Add(new Leaf(""));
            branchone.Add(leaf);
            trunk.Display(1);
            Console.WriteLine();
        }

        public static void Decorator()
        {
            Console.WriteLine("Decorator \n");
            DecoratorFruit Banana = new DecoratorBanana();
            DecoratorFruit Apple = new DecoratorApple();
            Decorator deco = new YellowFruit(Banana);
            Apple.ShowSelf();
            deco.ShowSelf();
            Console.WriteLine();
        }

        public static void Facade()
        {
            Console.WriteLine("Facade \n");
            FacadeFruitMaker fMaker = new FacadeFruitMaker();
            fMaker.ShowFruit("Banana");
            fMaker.ShowFruit("Apple");
            fMaker.ShowFruit("Orange");
            Console.WriteLine();
        }

        public static void Flyweight()
        {
            Console.WriteLine("Flyweight \n");
            FlyweightClient BananaOne = new FlyweightClient("Banana");
            FlyweightClient BananaTwo = new FlyweightClient("Banana");
            FlyweightClient Apple = new FlyweightClient("Apple");
            BananaOne.SetWeight(10);
            BananaTwo.SetWeight(20);
            Apple.SetWeight(30);
            FlyweightFruitFactory.howManyFruit("Banana");
            Console.WriteLine();
        }

        public static void Proxy()
        {
            Console.WriteLine("Proxy \n");
            ProxyAdder pAdder = new ProxyAdder();
            pAdder.Calculate(50, 50);
            pAdder.Calculate(-40, 120);
            Console.WriteLine();
        }

        public static void ChainOfResponsibility()
        {
            Console.WriteLine("chain Of Responsibility \n");
            HandlerA a = new HandlerA();
            a.SetSuccessor(new HandlerB());
            HandlerB b = new HandlerB();
            b.SetSuccessor(new HandlerA());

            a.HandleRequest(5);
            Console.WriteLine();
            a.HandleRequest(15);
            Console.WriteLine();
            b.HandleRequest(5);
            Console.WriteLine();
            b.HandleRequest(15);
            Console.WriteLine();
        }

        public static void Command()
        {
            Console.WriteLine("Command \n");
            CommandClient cClient = new CommandClient();
            cClient.RunCommand("This is the message");
            Console.WriteLine();
        }

        public static void Interpreter()
        {
            Console.WriteLine("Interpreter \n");
            RomanInterpretter romanInt = new RomanInterpretter();
            string RomanVal = "MCMXXVIII";
            Console.WriteLine(RomanVal + " in decimal is " + romanInt.Interpret(RomanVal));
            Console.WriteLine();
        }

        public static void Mediator()
        {
            Console.WriteLine("Mediator \n");
            Mediator med = new Mediator();
            MediatorOutputOne medOne = new MediatorOutputOne(med);
            MediatorOutputTwo medTwo = new MediatorOutputTwo(med);
            MediatorOutputOne medThree = new MediatorOutputOne(med);
            medOne.Send();
            Console.WriteLine();
            medTwo.Send();
            Console.WriteLine();
            medThree.Send();
            Console.WriteLine();
        }

        public static void Memento()
        {
            Console.WriteLine("Memento \n");
            Caretaker caretaker = new Caretaker();
            MementoFruit fruit = new MementoFruit("Banana",10);
            fruit.ShowSelf();
            caretaker.AddMemento(fruit.GetMemento());
            fruit.name = "Apple";
            fruit.weight = 20;
            fruit.ShowSelf();
            caretaker.AddMemento(fruit.GetMemento());
            fruit.name = "Orange";
            fruit.weight = 30;
            fruit.ShowSelf();
            fruit.SetMemento((MementoImplement)caretaker.GetLastMemento());
            fruit.ShowSelf();
            fruit.SetMemento((MementoImplement)caretaker.GetLastMemento());
            fruit.ShowSelf();
            Console.WriteLine();
        }

        public static void Observer()
        {
            Console.WriteLine("Observer \n");
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observerOne = new ConcreteObserver();
            ConcreteObserver observerTwo = new ConcreteObserver();

            observerOne.AddSubject(subject);
            observerTwo.AddSubject(subject);
            subject.SendMessageUpdate("Hello!");
            Console.WriteLine();
        }

        public static void State()
        {
            Console.WriteLine("State \n");
            Context context = new Context(new ConcreteStateBaseA());
            context.Request();
            context.Request();
            Console.WriteLine();
        }

        public static void Strategy()
        {
            Console.WriteLine("Strategy \n");
            StrategyFruitMaker fruitMaker = new StrategyFruitMaker();
            fruitMaker.strategy = new StrategyApple();
            fruitMaker.CallStrategy();
            fruitMaker.strategy = new StrategyBanana();
            fruitMaker.CallStrategy();
            Console.WriteLine();
        }

        public static void Template()
        {
            Console.WriteLine("Template \n");
            TemplateOne tOne = new TemplateOne();
            TemplateTwo tTwo = new TemplateTwo();
            tOne.RunCalculation();
            tTwo.RunCalculation();
            Console.WriteLine();
        }

        public static void Visitor()
        {
            Console.WriteLine("Visitor \n");
            VisitorObject visitorObj = new VisitorObject();
            ElementOne elemOne = new ElementOne();
            ElementTwo elemTwo = new ElementTwo();
            visitorObj.AddElement(elemOne);
            visitorObj.AddElement(elemTwo);
            visitorObj.UseVisitor(new VisitorOne());
            visitorObj.UseVisitor(new VisitorTwo());
            Console.WriteLine("Element one value; " + elemOne.Value);
            Console.WriteLine("Element two value; " + elemTwo.Value);
            Console.WriteLine();
        }
    }
}
