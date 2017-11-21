using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class ChainHandler
    {
        protected ChainHandler successor;

        public abstract void HandleRequest(int request);

        public void SetSuccessor(ChainHandler successor)
        {
            this.successor = successor;
        }
    }

    public class HandlerA : ChainHandler
    {
        public override void HandleRequest(int request)
        {
            if(request > 10)
            {
                Console.WriteLine("Value is over or equal to 10 : sending to successor");
                if(successor != null)
                    successor.HandleRequest(request);
            }else
            {
                Console.WriteLine("Value is under 10");
            }
        }
    }

    public class HandlerB : ChainHandler
    {
        public override void HandleRequest(int request)
        {
            if (request > 10) {
                Console.WriteLine("Value is over or equal to 10");
            }else
            {
                Console.WriteLine("Value is under 10 : sending to successor");
                if (successor != null)
                    successor.HandleRequest(request);
            }
        }
    }
}
