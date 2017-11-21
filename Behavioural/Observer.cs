using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Subject
    {
        protected List<Observer> Observers = new List<Observer>();

        public void AddObserver(Observer observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            if (Observers.Contains(observer))
                Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(Observer o in Observers)
            {
                o.Update();
            }
        }
    }

    public class ConcreteSubject : Subject
    {
        private string message;
        public void SendMessageUpdate(string message)
        {
            this.message = message;
            Notify();
        }

        public string GetUpdate()
        {
            return message;
        }
    }

    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;

        public void AddSubject(ConcreteSubject subject)
        {
            this.subject = subject;
            subject.AddObserver(this);
        }
        public override void Update()
        {

            Console.WriteLine("My subject updated and has the message " + subject.GetUpdate());
        }
    }
}
