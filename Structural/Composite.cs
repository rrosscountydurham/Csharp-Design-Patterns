using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Component
    {
        protected List<Component> children = new List<Component>();
        protected string name;

        public Component(string name) { this.name = name; }
        public abstract void Add(Component comp);
        public abstract void Remove(Component comp);
        public void Display(int depth)
        {
            Console.WriteLine("My name is " + name + " and I'm at depth " + depth);
            foreach (Component c in children)
            {
                c.Display(depth + 1);
            }
        }
    }

    public class Branch : Component
    {
        public Branch(string name) : base(name) { }
        public override void Add(Component comp)
        {
            children.Add(comp);
        }

        public override void Remove(Component comp)
        {
            children.Remove(comp);
        }
    }

    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Add(Component comp)
        {
            Console.WriteLine("Cannot add to leaf");
        }

        public override void Remove(Component comp)
        {
            Console.WriteLine("Cannot remove from leaf");
        }
    }
}
