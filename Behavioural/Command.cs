using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CommandClient
    {
        public void RunCommand(string message)
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            Command command = new Command(receiver);
            command.Parameter = message;
            invoker.command = command;
            invoker.ExecuteCommand();
        }
    }

    public class Receiver {
        public void Action(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Invoker {
        public CommandBase command { get; set; }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    }

    public abstract class CommandBase {
        protected Receiver receiver;

        public CommandBase(Receiver receiver) {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }

    public class Command : CommandBase {

        public string Parameter { get; set; }
        public Command(Receiver receiver) : base(receiver) { }

        public override void Execute()
        {
            receiver.Action(Parameter);   
        }
    }
}
