using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class EventPublisher
    {
        private int _value;

        public EventPublisher(int value)
        {
            _value = value;
        }

        public int Value { 
            get 
            { 
                return _value; 
            } 
            set 
            {
                /*
                if (ValueHasChanged != null) 
                    ValueHasChanged(this, new ExampleEventArgs(value));
                */
                ValueHasChanged?.Invoke(this, new ExampleEventArgs(value));
                _value = value;
            } 
        }

        public event ExampleEventHandler ValueHasChanged; // metoda


    }
}
