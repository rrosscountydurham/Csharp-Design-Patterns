using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{ 
    public class SingletonType
    {
        private static SingletonType _instance;
        public static string myName = "Terry";

        protected SingletonType() {}

        public static SingletonType Instance()
        {
            if (_instance == null)
                _instance = new SingletonType();

            return _instance;
        }

        public void Nameself()
        {
            Console.WriteLine("I am a SingletonType named " + myName);
        }
    }
}
