using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class ColleagueBase
    {
        protected MediatorBase mediator;

        public ColleagueBase(MediatorBase mediator) {
            this.mediator = mediator;
            mediator.AddColleague(this);
        }
        public abstract void Send();
        public abstract void Receive(string message);
    }

    public class MediatorOutputOne : ColleagueBase
    {
        public MediatorOutputOne(MediatorBase mediator) : base(mediator){ }
        public override void Receive(string message)
        {
            Console.WriteLine(message + " Sent to an object of type One");
        }

        public override void Send()
        {
            mediator.SendMessage(this, "Message from type One");
        }
    }

    public class MediatorOutputTwo : ColleagueBase
    {
        public MediatorOutputTwo(MediatorBase mediator) : base(mediator){ }
        public override void Receive(string message)
        {
            Console.WriteLine(message + " Sent to an object of type Two");
        }

        public override void Send()
        {
            mediator.SendMessage(this, "Message from type Two");
        }
    }

    public abstract class MediatorBase
    {
        public abstract void AddColleague(ColleagueBase colleague);
        public abstract void SendMessage(ColleagueBase caller, string message);
    }

    public class Mediator : MediatorBase
    {
        private List<ColleagueBase> colleagues = new List<ColleagueBase>();

        public override void AddColleague(ColleagueBase colleague)
        {
            colleagues.Add(colleague);
        }
        public override void SendMessage(ColleagueBase caller, string message)
        {
            foreach(ColleagueBase c in colleagues)
            {
                if(c != caller)
                {
                    c.Receive(message);
                }
            }
        }
    }
}
