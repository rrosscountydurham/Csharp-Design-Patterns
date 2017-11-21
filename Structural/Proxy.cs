using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class ProxyBase
    {
        public abstract void Calculate(int a, int b);
    }

    public class ProxyRealAdder : ProxyBase
    {
        public override void Calculate(int a, int b)
        {
            Console.WriteLine(a + " + " + b + " = " + (a + b));
        }
    }

    public  class ProxyAdder : ProxyBase
    {
        private ProxyRealAdder pAdder = new ProxyRealAdder();

        public override void Calculate(int a, int b)
        {
            if(a > 0 && a <= 100 && b > 0 &&b <= 100)
            {
                pAdder.Calculate(a, b);
            }else
            {
                Console.WriteLine("Values outside of limits");
            }
        }
    }
}
