using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void ExampleEventHandler(object sender, ExampleEventArgs e);

    public class ExampleEventArgs
    {
        public ExampleEventArgs(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }
}
