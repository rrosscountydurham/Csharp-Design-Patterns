using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class FlyweightFruit
    {
        public string name;
        public string colour;

        public abstract void SetWeight(int weight);
        public abstract int GetNumber();
    }

    public class FlyweightBanana : FlyweightFruit
    {
        public static int numberOf;

        public FlyweightBanana() { numberOf++; }
        public override void SetWeight(int weight)
        {
            Console.WriteLine("New weight of this " + name + " which is " + colour + " is " + weight);
        }
        public override int GetNumber() { return numberOf; }
    }

    public class FlyweightApple : FlyweightFruit
    {
        public static int numberOf;

        public FlyweightApple() { numberOf++; }
        public override void SetWeight(int weight)
        {
            Console.WriteLine("New weight of this " + name + " which is " + colour + " is " + weight);
        }
        public override int GetNumber() { return numberOf; }
    }

    public class FlyweightClient
    {
        private FlyweightFruit fruit;
        public int weight;

        public FlyweightClient(string fruit)
        {
            this.fruit = FlyweightFruitFactory.getFruit(fruit);
        }

        public void SetWeight(int weight)
        {
            fruit.SetWeight(weight);
            this.weight = weight;
        }
    }

    public static class FlyweightFruitFactory
    {
        private static Dictionary<string, FlyweightFruit> flyweights = new Dictionary<string, FlyweightFruit>();

        public static FlyweightFruit getFruit(string key)
        {
            if (flyweights.ContainsKey(key))
            {
                return flyweights[key];
            }
            switch (key)
            {
                case "Banana":
                    flyweights[key] = new FlyweightBanana();
                    flyweights[key].colour = "Yellow";
                    flyweights[key].name = "Banana";
                    return flyweights[key];
                case "Apple":
                    flyweights[key] = new FlyweightApple();
                    flyweights[key].colour = "Red";
                    flyweights[key].name = "Apple";
                    return flyweights[key];
                default: break;
            }
            Console.WriteLine("Invalid fruit");
            return null;
        }

        public static void howManyFruit(string fruit)
        {
            if(flyweights.ContainsKey(fruit))
                Console.WriteLine("There are " + flyweights[fruit].GetNumber() + " " + fruit + "s");
        }
    }
}
