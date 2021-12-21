using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Operations<T1,T2>
    {
        public Operations(T1 x, T2 y)
        {
            X = x;
            Y = y;
        }

        public T1 X { get; set; }
        public T2 Y { get; set; }
        public bool IsEqual { get { return X.Equals(Y); } }

    }
}
