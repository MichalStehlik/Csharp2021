using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    internal class DataItem
    {
        public int Count { get; set; }
        public string Description { get; set; }

        public DataItem(int count, string description)
        {
            Count = count;
            Description = description;
        }

        public static DataItem operator +(DataItem i1, DataItem i2)
        {
            return new DataItem(i1.Count + i2.Count, "něco");
        }

        public static DataItem operator +(DataItem i1, int num)
        {
            return new DataItem(i1.Count + num, i1.Description);
        }

        public override string ToString()
        {
            return Count + "x " + Description;
        }
    }
}
