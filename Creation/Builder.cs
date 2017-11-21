using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class BuilderProduct
    {
        private List<string> _bits = new List<string>();

        public void Add(string bit)
        {
            _bits.Add(bit);
        }

        public void Show()
        {
            Console.WriteLine("My parts are ");
            foreach(string s in _bits)
            {
                Console.WriteLine(s + " ");
            }
            Console.WriteLine();
        }
    }

    abstract class Builder
    {
        protected BuilderProduct bProduct = new BuilderProduct();
        public abstract void MakePartA();
        public abstract void MakePartB();
        public BuilderProduct GetResult() { return bProduct; }
    }

    class ConcreteBuilderOne : Builder
    {
        public override void MakePartA()
        {
            bProduct.Add("Part A Of Builder One");  
        }

        public override void MakePartB()
        {
            bProduct.Add("Part B Of Builder One");
        }
    }

    class ConcreteBuilderTwo : Builder
    {
        public override void MakePartA()
        {
            bProduct.Add("Part A Of Builder Two");
        }

        public override void MakePartB()
        {
            bProduct.Add("Part B Of Builder Two");
        }
    }


}
