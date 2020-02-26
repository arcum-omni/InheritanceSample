using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    class Student : Person
    {
        public string Major { get; set; }

        public override void Register(params string[] courses)
        {
            // Reg stu for selected courses
            // Charge fees to account, etc.
            Console.WriteLine("Reg Successful");
        }
    }
}
