using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Memento
    {
    }

    public class MementoImplement : Memento
    {
        public string name { get; private set; }
        public int weight { get; private set; }

        public MementoImplement(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }
    }
    public class MementoFruit
    {
        public string name;
        public int weight;

        public MementoFruit(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public MementoImplement GetMemento()
        {
            return new MementoImplement(name, weight);
        }

        public void SetMemento(MementoImplement memento)
        {
            name = memento.name;
            weight = memento.weight;
        }

        public void ShowSelf()
        {
            Console.WriteLine("I am a " + name + " which weighs " + weight);
        }
    }

    public class Caretaker
    {
        List<Memento> Mementos = new List<Memento>();

        public void AddMemento(Memento memento)
        {
            Mementos.Add(memento);
        }

        public Memento GetLastMemento()
        {
            Memento mementoReturn = Mementos.Last();
            Mementos.Remove(mementoReturn);
            return mementoReturn;
        }
    }
}
