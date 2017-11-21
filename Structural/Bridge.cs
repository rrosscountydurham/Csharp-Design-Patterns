using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class BridgeFruit
    {
        public string Name;
        public int Weight;

        public void PrintSelf()
        {
            Console.WriteLine("I am a " + Name + " and I weigh " + Weight);
        }
    }

    public class BridgeObject
    {
        private BridgeFruit bFruit;
        private Implementation implementation;

        public BridgeObject(Implementation implementation)
        {
            this.implementation = implementation;
        }
        public void DoProduct()
        {
            bFruit = new BridgeFruit();
            implementation.DoThingOne(bFruit);
            implementation.DoThingTwo(bFruit);
        }

        public BridgeFruit GetFruit()
        {
            return bFruit;
        }
    }

    public interface Implementation
    {
        void DoThingOne(BridgeFruit bFruit);
        void DoThingTwo(BridgeFruit bFruit);
    }

    public class ImplementationOne : Implementation
    {
        public void DoThingOne(BridgeFruit bFruit)
        {
            bFruit.Name = "Banana";
        }

        public void DoThingTwo(BridgeFruit bFruit)
        {
            bFruit.Weight = 10;
        }
    }

    public class ImplementationTwo : Implementation
    {
        public void DoThingOne(BridgeFruit bFruit)
        {
            bFruit.Name = "Apple";
        }

        public void DoThingTwo(BridgeFruit bFruit)
        {
            bFruit.Weight = 5;
        }
    }
}
