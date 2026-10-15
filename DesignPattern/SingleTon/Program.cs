using System;
namespace SingleTon
{

    public sealed class Singleton
    {
        private Singleton()
        {
        }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The Client code 
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            if (s1 == s2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}