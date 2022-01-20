using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class EventSubscriber
    {
        public void OnValueChanged(object sender, ExampleEventArgs e)
        {
            Console.WriteLine(sender.ToString() + "value is " + e.Value);
        }
    }
}
