using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class TemplateBase
    {
        public int value;
        public void RunCalculation()
        {
            Step1();
            Step2();
            Step3();
            Console.WriteLine("The value is now " + value);
        }

        protected abstract void Step1();
        protected abstract void Step2();
        protected abstract void Step3();

    }

    public class TemplateOne : TemplateBase
    {
        protected override void Step1()
        {
            value = 10;
        }

        protected override void Step2()
        {
            value += 10;
        }

        protected override void Step3()
        {
            value *= 10;
        }
    }

    public class TemplateTwo : TemplateBase
    {
        protected override void Step1()
        {
            value = 5;
        }

        protected override void Step2()
        {
            value -= 2;
        }

        protected override void Step3()
        {
            value /= 3;
        }
    }
}
