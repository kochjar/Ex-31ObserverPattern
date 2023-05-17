using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_31ObserverPattern
{
    public class Student : Person, IObserver
    {
        private Academy academy;

        public string Message { get; set; }

        public Student(Academy academy, string name) : base(name)
        {
            this.academy = academy;
            this.Message = academy.Message;
        }

        public void Update()
        {
            this.Message = this.academy.Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra akademiet {academy.Name}");
        }
    }
}
