using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo.Model
{
    internal class Mark
    {
        public Mark(string firstName, string lastName, string className, string subject, int value, DateTime created)
        {
            FirstName = firstName;
            LastName = lastName;
            ClassName = className;
            Subject = subject;
            Value = value;
            Created = created;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassName { get; set; }
        public string Subject { get; set; }
        public int Value { get; set; }
        public DateTime Created { get; set; }

        public override string ToString()
        {
            return String.Format("Student {0} {1} ({2}), {3}, {4} ({5})", FirstName, LastName, ClassName, Subject, Value, Created);
        }
    }
}
