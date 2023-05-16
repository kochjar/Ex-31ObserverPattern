using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_31ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject subject;
        private int state = 0;

        public int State { get { return state; } set { state = value; } }

        public ConcreteObserver(ConcreteSubject subject) 
        { this.subject = subject;
          this.state = subject.State;
        }

        public override void Update()
        {
            this.state = this.subject.State;
        }
    }
}
