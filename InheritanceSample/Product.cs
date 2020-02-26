using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code"></param>
        public Product(string code)
        {
            Code = code;
        }

        public string Code { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string GetDisplayText()
        {
            return Code;
        }

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
        public Book(string bookCode) : base(bookCode)
        {
            Code = bookCode;
        }

        /// <summary>
        /// The author of the book, default is Joel Murach.
        /// </summary>
        public string Author { get; set; } = "Unknown";

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
        public Software(string softwareCode) : base(softwareCode)
        {
            Code = softwareCode;
        }

        public string Version { get; set; }

        public new string GetDisplayText()
        {
            return Version;
        }

        public override string ToString()
        {
            return base.ToString() + $"  Ver: {Version}\n";
        }
    }

    /// <summary>
    /// MobileApplication, subtype of Software
    /// </summary>
    class MobileApplication : Software
    {
        public MobileApplication(string mobileAppCode) : base(mobileAppCode)
        {
            Code = mobileAppCode;
        }

        public string MobileOS { get; set; }

        //public override string ToString()
        //{
        //    return base.ToString() + $"  OS: {MobileOS}\n";
        //}

        // Expression bodies member: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members
        // EBM Method (alternate syntax), same behavior/performance as above
        public override string ToString() => base.ToString() + $"  OS: {MobileOS}\n";
    }
}