using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns {
    public class ContextData
    {
        public string input;
        public int output = 0;
    }

    public abstract class InterpreterExpression
    {
        public void Interpret(ContextData context)
        {
            if (context.input.Length == 0)
                return;

            if (context.input.StartsWith(Four()))
            {
                ParseValue(context, 4, 2);
            }
            else if (context.input.StartsWith(Five()))
            {
                ParseValue(context, 5, 1);
            }
            else if (context.input.StartsWith(Nine()))
            {
                ParseValue(context, 9, 2);
            }

            if (context.input.StartsWith(One()))
            {
                while (context.input.StartsWith(One()))
                {
                    ParseValue(context, 1, 1);
                }
            }
        }

        protected void ParseValue(ContextData context, int multi, int sub)
        {
            context.output += (multi * Multiplier());
            context.input = context.input.Substring(sub);
        }

        public abstract string One();
        public abstract string Four();
        public abstract string Five();
        public abstract string Nine();
        public abstract int Multiplier();
    }

    public class Thousands : InterpreterExpression
    {
        public override string Five(){return " ";}

        public override string Four(){return " ";}

        public override int Multiplier(){return 1000;}

        public override string Nine(){return " ";}

        public override string One(){return "M";}
    }

    public class Hundreds : InterpreterExpression
    {
        public override string One() { return "C"; }
        public override string Four() { return "CD"; }
        public override string Five() { return "D"; }
        public override string Nine() { return "CM"; }
        public override int Multiplier(){ return 100; }
    }

    public class Tens : InterpreterExpression
    {
        public override string One() { return "X"; }
        public override string Four() { return "XL"; }
        public override string Five() { return "L"; }
        public override string Nine() { return "XC"; }
        public override int Multiplier() { return 10; }
    }

    public class Ones : InterpreterExpression
    {
        public override string One() { return "I"; }
        public override string Four() { return "IV"; }
        public override string Five() { return "V"; }
        public override string Nine() { return "IX"; }
        public override int Multiplier() { return 1; }
    }

    public class RomanInterpretter
    {
        List<InterpreterExpression> exp = new List<InterpreterExpression>();

        public RomanInterpretter()
        {
            exp.Add(new Thousands());
            exp.Add(new Hundreds());
            exp.Add(new Tens());
            exp.Add(new Ones());
        }

        public string Interpret(string input)
        {
            ContextData context = new ContextData();
            context.input = input;
            foreach(InterpreterExpression e in exp)
            {
                e.Interpret(context);
            }
            return context.output.ToString();
        }
    }
}
