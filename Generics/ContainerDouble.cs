using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ContainerDouble
    {
        public ContainerDouble(double content)
        {
            Content = content;
        }

        public double Content { get; private set; }
        public override string ToString()
        {
            return Content.ToString();
        }
    }
}
