using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Container<T>
    {
        public Container(T content)
        {
            Content = content;
        }

        public T Content { get; private set; }
        public override string ToString()
        {
            if (Content is null)
                return "";
            return Content.ToString();
        }
    }
}
