using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    abstract class Person
    {
        public int PersonID { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public abstract void Register(params string[] courses);
    }
}
