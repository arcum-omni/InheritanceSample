using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    class Instructor : Person
    {
        public string OfficeLocation { get; set; }

        public override void Register(params string[] courses)
        {
            Console.WriteLine("Enjoy your reg discount");
        }
    }
}
