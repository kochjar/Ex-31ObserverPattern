using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_31ObserverPattern
{
    public class Student : Observer
    {
        private Academy subject;

        public string Name { get; }

        public string Message { get; set; }

        public Student(Academy subject, string name)
        {
            this.subject = subject;
            this.Name = name;
            this.Message = subject.Message;
        }

        public override void Update()
        {
            this.Message = this.subject.Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden '{this.Message}' fra akademiet {this.subject.Name}");
        }
    }
}
