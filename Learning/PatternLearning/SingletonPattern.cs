using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PatternLearning
{
    class SingletonPattern
    {
        private static Random rnd = new Random();
        private static int randomValue;
        private static readonly object _lock = new object();
        private SingletonPattern()
        {
            randomValue = rnd.Next();
        }
        private static SingletonPattern _singleton;

        private static SingletonPattern GetSingleton()
        {
            if (_singleton == null)
            {
                lock (_lock)
                {
                    _singleton = new SingletonPattern() { };
                }
            }
            return _singleton;
        }
        public static void GetRandomValue()
        {
            var threadInfo = Thread.CurrentThread;
            GetSingleton();
            Console.WriteLine(threadInfo.ManagedThreadId + " Run");
            Thread.Sleep(rnd.Next(0,5000));
            Console.WriteLine(threadInfo.ManagedThreadId + " Value " + randomValue);
            Thread.Sleep(rnd.Next(0, 5000));
            Console.WriteLine(threadInfo.ManagedThreadId + " End");
        }
    }
}
