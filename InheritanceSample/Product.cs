using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    class Product
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return $"SKU: {Code}\n  Description: {Description}\n  Price: ${Price}\n";
        }
    }

    class Book : Product
    {
        public string Author { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"  Author: {Author}\n";
        }
    }

    class Software : Product
    {
        public string Version { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"  Ver: {Version}\n";
        }
    }
}
