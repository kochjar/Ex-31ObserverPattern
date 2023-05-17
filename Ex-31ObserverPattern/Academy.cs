using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_31ObserverPattern
{
    public delegate void NotifyHandler();

    public class Academy : Organization
    {
        public NotifyHandler MessageChanged;

        private string message;

        public string Message {
            get { return message;  } 
            set {
                if (message != value)
                {
                    message = value; MessageChanged();
                }
            } 
        }

        public Academy(string name, string address) : base(name)
        {
            Address = address;
        }

        public void OnMessageChanged()
        {

        }

    }
}
