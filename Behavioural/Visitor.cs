using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class VisitorObject {
        private List<ElementBase> elements = new List<ElementBase>();

        public void UseVisitor(VisitorBase visitor)
        {
            foreach(ElementBase e in elements)
            {
                e.AcceptVisitor(visitor);
            }
        }

        public void AddElement(ElementBase element)
        {
            elements.Add(element);
        }
    }

    public abstract class VisitorBase {
        public abstract void AcceptElement(ElementOne element);
        public abstract void AcceptElement(ElementTwo element);
    }

    public class VisitorOne : VisitorBase
    {
        public override void AcceptElement(ElementOne element)
        {
            element.Value += 1;
        }

        public override void AcceptElement(ElementTwo element)
        {
            element.Value += "One";
        }
    }

    public class VisitorTwo : VisitorBase
    {
        public override void AcceptElement(ElementOne element)
        {
            element.Value += 2;
        }

        public override void AcceptElement(ElementTwo element)
        {
            element.Value += "Two";
        }
    }



    public abstract class ElementBase {
        public abstract void AcceptVisitor(VisitorBase visitor);
    }

    public class ElementOne : ElementBase
    {
        public int Value;
        public override void AcceptVisitor(VisitorBase visitor)
        {
            Console.WriteLine("Visitor to Element One");
            visitor.AcceptElement(this);
        }
    }

    public class ElementTwo : ElementBase
    {
        public string Value;

        public override void AcceptVisitor(VisitorBase visitor)
        {
            Console.WriteLine("Visitor to Element Two");
            visitor.AcceptElement(this);
        }
    }
}
