using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static bool IsCountEven<T>(this List<T> items)
        {
            return (items.Count() % 2 == 0);
        }

        public static List<string> ShorterThen(this List<string> items, int length)
        {
            var n = new List<string>();
            foreach (var x in items)
            {
                if (x.Length < length) n.Add(x);
            }
            return n;
        }

        public static List<T> Even<T>(this List<T> items)
        {
            var n = new List<T>();
            for (int i = 0; i < items.Count(); i++)
            {
                if (i % 2 == 0) n.Add(items[i]);
            }
            return n;
        }

        public static List<T> Condition<T>(this List<T> items, Func<T, bool> cond)
        {
            var n = new List<T>();
            foreach (var x in items)
            {
                if (cond(x)) n.Add(x);
            }
            return n;
        }
    }
}
