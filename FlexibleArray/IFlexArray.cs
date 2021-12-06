using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleArray
{
    public interface IFlexArray
    {
        public void Add(object o);
        public object Get(int index);
        public void Set(int index, object o);
        public int? IndexOf(object o);
        public object[] GetAll();
        public int Count { get; }
        public int Length { get; }
        public void Insert(int index, object o);
        public void Remove(object o);
        public void RemoveAt(int index);
        public object this[int index] { get; set; }
        public void EmptyAt(int index);
        public void Empty(object o);
    }
}
