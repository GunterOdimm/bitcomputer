using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project3
{
    delegate void Notify(String message);
    class Notifier
    {
        public Notify EventOccured;
    }
    class EventListener
    {
        private String name;
        public EventListener(String name)
        {
            this.name = name;
        }
        
        public void SomethingHappend(String message)
        {
            WriteLine($"{name}.SomethingHappend : {message}");
        }
    

    }
    class DelegateChain2Ex
    {
        static void main(String[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            // notifier.EventOccured = new Notify(listener1.SomethingHappend);
            notifier.EventOccured = listener1.SomethingHappend;
            notifier.EventOccured += listener2.SomethingHappend;
            notifier.EventOccured += listener3.SomethingHappend;
            notifier.EventOccured("You'vs got mail.");
            WriteLine();

             

            notifier.EventOccured -= listener2.SomethingHappend;
            notifier.EventOccured("Download completed.");
            WriteLine();

            

            // 위랑 동작은 정확히 똑같은데 표기법이 다르다.
            Notify notifier1 = new Notify(listener1.SomethingHappend);
            Notify notifier2 = new Notify(listener2.SomethingHappend);
            notifier.EventOccured = (Notify)Delegate.Combine(notifier1, notifier2);
            notifier.EventOccured("Fire!");
            WriteLine();

            notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notifier2);
            notifier.EventOccured("Game over!");
        }
    }
}
