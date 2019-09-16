using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance();
            Singleton singleton2 = Singleton.Instance();

            singleton1.HelloThere("Songoku");
            singleton2.HelloThere("Doraemon");
            Console.WriteLine(Singleton.GetTotalInstances());
        }
    }
}
