using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ContainerString
    {
        public ContainerString(string content)
        {
            Content = content;
        }

        public string Content { get; private set; }
        public override string ToString()
        {
            return Content.ToString();
        }
    }
}
