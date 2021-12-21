using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ContainerInt
    {
        public ContainerInt(int content)
        {
            Content = content;
        }

        public int Content { get; private set; }
        public override string ToString()
        {
            return Content.ToString();
        }
    }
}
