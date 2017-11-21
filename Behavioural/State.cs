using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Context
    {
        public StateBase state;

        public Context(StateBase state)
        {
            this.state = state;
        }

        public void Request()
        {
            state.Handle(this);
        }
    }

    public abstract class StateBase
    {
        public abstract void Handle(Context context);
    }

    public class ConcreteStateBaseA : StateBase
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Currently base A. Changing to base B");
            context.state = new ConcreteStateBaseB();
        }
    }

    public class ConcreteStateBaseB : StateBase
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Currently base B. Changing to base A");
            context.state = new ConcreteStateBaseA();
        }
    }
}
