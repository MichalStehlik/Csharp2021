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

        public object this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(object o)
        {
            Resize(ref _array, Length+1);
            _array[Length-1] = o;
        }

        public object Get(int index)
        {
            if (index < 0 || index > _array.Length) throw new ArgumentOutOfRangeException("Out of range");
            return _array[index];
        }

        public object[] GetAll()
        {
            return _array;
        }

        public IEnumerator GetEnumerator()
        {
            return _array.GetEnumerator();
        }

        public int? IndexOf(object o)
        {
            throw new NotImplementedException();
        }

        public void Set(int index, object o)
        {
            if (index < 0) throw new ArgumentOutOfRangeException();
            if (index > _array.Length) Resize(ref _array, _array.Length);
            _array[index] = o;
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

        protected int? FindFirstEmpty(ref object[] arr, int fromIndex = 0)
        {
            for (int i = fromIndex; i < arr.Length; i++)
            {
                if (arr[i] == null) return i;
            }
            return null;
        }

        public void ShiftItemsUp(int index, int size = 1)
        {

        }

        public void ShiftItemsDown(int index, int size = 1)
        {

        }


        //123456
        //12x3456

        public void Insert(int index, object o)
        {
            throw new NotImplementedException();
        }

        public void Remove(object o)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void EmptyAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Empty(object o)
        {
            throw new NotImplementedException();
        }
    }
}
