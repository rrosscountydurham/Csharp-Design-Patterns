using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface FacadeFruit
    {
        void ShowSelf();
    }

    public class FacadeBanana : FacadeFruit
    {
        public void ShowSelf()
        {
            Console.WriteLine("I am a banana");
        }
    }

    public class FacadeApple : FacadeFruit
    {
        public void ShowSelf()
        {
            Console.WriteLine("I am an apple");
        }
    }

    public class FacadeOrange : FacadeFruit
    {
        public void ShowSelf()
        {
            Console.WriteLine("I am an orange");
        }
    }

    public class FacadeFruitMaker
    {
        private FacadeBanana fBanana = new FacadeBanana();
        private FacadeApple fApple = new FacadeApple();
        private FacadeOrange fOrange = new FacadeOrange();

        public void ShowFruit(string fruit)
        {
            switch (fruit)
            {
                case "Banana": fBanana.ShowSelf(); break;
                case "Apple": fApple.ShowSelf(); break;
                case "Orange": fOrange.ShowSelf(); break;
                default: Console.WriteLine("Fruit not found"); break;
            }
        }
    }
}
