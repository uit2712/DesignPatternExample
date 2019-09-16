using System;

namespace SingletonPattern
{
    class Singleton
    {
        protected static Singleton _instance = null;
        protected static int _totalInstances = 0;
        
        protected Singleton() { _totalInstances++; }

        public static Singleton Instance()
        {
            if (_instance == null)
                _instance = new Singleton();

            return _instance;
        }

        public static int GetTotalInstances()
        {
            return _totalInstances;
        }

        public void HelloThere(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
