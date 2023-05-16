using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_31ObserverPattern
{
    public class Academy : Organization, ISubject
    {
        private List<IObserver> students = new List<IObserver>();
 

        private string message;

        public string Message { get { return message;  } set { message = value; Notify(); } }

        public Academy(string name, string address) : base(name)
        {
            Address = address;
        }

        public void Attach(IObserver observer)
        {
            students.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            students.Remove(observer);
        }

        public void Notify()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"Studerende {student.Name} modtog nyheden '{Message}' fra akademiet {Name}");
            }
            
        }

    }
}
