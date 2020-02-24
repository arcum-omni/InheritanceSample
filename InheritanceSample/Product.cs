using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    /// <summary>
    /// Product Object
    /// </summary>
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

    /// <summary>
    /// Book, subtype of Product
    /// </summary>
    class Book : Product
    {
        public string Author { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"  Author: {Author}\n";
        }
    }

    /// <summary>
    /// Software, subtype of Product
    /// </summary>
    class Software : Product
    {
        public string Version { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"  Ver: {Version}\n";
        }
    }

    class MobileApplication : Software
    {
        public string MobileOS { get; set; }

        public override string ToString()
        {
            return base.ToString() +$"  OS: {MobileOS}\n";
        }
    }
}