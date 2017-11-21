using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Prototype
    {
        protected string selfName;
        public abstract Prototype CloneSelf();
        public void Nameself()
        {
            Console.WriteLine("My name is " + selfName);
        }

        public void ChangeName(string nameIn)
        {
            selfName = nameIn;
        }
    }
    public class ConcretePrototype : Prototype
    {
        public ConcretePrototype(string nameIn)
        {
            selfName = nameIn;
        }

        public override Prototype CloneSelf()
        {
            return new ConcretePrototype(selfName);
        }

    }
}