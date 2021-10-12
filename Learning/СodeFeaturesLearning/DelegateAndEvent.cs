using System;

namespace Learning
{
    class DelegateAndEvent
    {
        delegate void MyDelegate();
        static void PrintMessage() { }
        void PrintMessage(string message) { }
        
        MyDelegate del = PrintMessage;
        Action action = PrintMessage;
    }

    abstract class asd {
        public static void PrintMessage() { Console.WriteLine("ASD"); }
        public int asdaaa { get; set; }
        public delegate void MyDelegate();
        public MyDelegate del = PrintMessage;
        public Action action;
        public Func<int> func;
        public Predicate<int> predicate;
        public void asdasdasd() { }
        public event MyDelegate Event;
    }

    public interface IEvent {
        static void PrintMessage() { Console.WriteLine("IASD"); }
        protected event MyDelegate Event;
        delegate void MyDelegate();
        public void asdasdasd() { } 
    }
    public interface IEvent2: IEvent
    {
        static void PrintMessage() { Console.WriteLine("IASD"); }
        public event MyDelegate Event;
        delegate void MyDelegate();
        public void asdasdasd() { }
    }

    class asdDc : asd { }
}
