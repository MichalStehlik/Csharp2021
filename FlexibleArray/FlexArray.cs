using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleArray
{
    public class FlexArray : IFlexArray, IEnumerable
    {
        protected object[] _array = new object[0];
        public int Count { get 
            {
                int cnt = 0;
                for (int i = 0; i < Length; i++)
                {
                    if (_array[i] != null) cnt++;
                }
                return cnt;
            } }

        public int Length { get { return _array.Length; } }

        public void Add(object o)
        {
            Resize(ref _array, Length+1);
            _array[Length-1] = o;
        }

        public object Get(int index)
        {
            throw new NotImplementedException();
        }

        public object[] GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object o)
        {
            throw new NotImplementedException();
        }

        public void Set(int index, object o)
        {
            throw new NotImplementedException();
        }

        protected void Resize(ref object[] old, int newSize)
        {
            if (newSize < 0) throw new ArgumentOutOfRangeException("Pole nemůže mít zápornou velikost");
            object[] newArray = new object[newSize];
            for (int i = 0; i < Math.Min(old.Length,newSize); i++)
            {
                newArray[i] = old[i];
            }
            old = newArray;
        }
    }
}
