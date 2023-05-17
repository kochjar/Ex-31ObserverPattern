using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_31ObserverPattern
{
    public delegate void NotifyHandler();

    public class Academy : Organization, ISubject
    {
        //private List<IObserver> students = new List<IObserver>();
        private NotifyHandler students;

        private string message;

        public string Message {
            get { return message;  } 
            set {
                if (message != value)
                {
                    message = value; Notify();
                }
            } 
        }

        public Academy(string name, string address) : base(name)
        {
            Address = address;
        }

        public void Attach(IObserver observer)
        {
            students += observer.Update;
        }

        public void Detach(IObserver observer)
        {
            students -= observer.Update;
        }

        public void Notify()
        {
            students();
        }

    }
}
