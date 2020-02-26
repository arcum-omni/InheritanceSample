using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    // C# Coding Conventions (C# Programming Guide)
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions

    class Program
    {
        static void Main(string[] args)
        {
            Person p; // undeclared person variable, not an instanciation
            Console.WriteLine("Are you student?");
            string input = Console.ReadLine();
            if (input == "y" || input == "yes")
            {
                p = new Student();
                Console.WriteLine("What is your major of study?");
                string major = Console.ReadLine();
                Student curStu = p as Student;
                curStu.Major = major;
            }
            else
            {
                p = new Instructor();
            }
            p.FullName = "Jonathan Smithe";
            p.Email = "smithe1234@student.cptc.edu";
            p.Register("CPW 101", "CPW 150");
            Console.ReadKey();
        }

        private static void ProductTesting()
        {
            #region TournamentEntry Data Manipulation
            //TournamentEntry te = new TournamentEntry();
            //te.AddGame(225);
            //te.AddGame(250);
            //te.AddGame(190);
            //te.AddGame(275);
            //te.AddGame(300);

            //te.AddGame(225, TournamentEntry.GameNumber.First);
            //te.AddGame(250, TournamentEntry.GameNumber.Second);
            //te.AddGame(190, TournamentEntry.GameNumber.Thrid);
            //te.AddGame(275, TournamentEntry.GameNumber.Fourth);
            //te.AddGame(300, TournamentEntry.GameNumber.First);
            #endregion

            Product p = new Product("00001")
            {
                Description = "A generic product",
                Price = 9.99
            };

            Book b = new Book("978-1890774943")
            {
                Description = "Murach's C# 2015 6th Edition",
                Price = 46.49,
                Author = "Joel Murach "
            };

            Software s = new Software("FQC-09525")
            {
                Description = "Windows 10 Pro",
                Price = 129.99,
                Version = "10.0.18363 Build 18363"
            };

            MobileApplication ma = new MobileApplication("MTAA-0001")
            {
                Description = "Target Archery App",
                Price = 99.99,
                Version = "1.0.0",
                MobileOS = "AppleOS"
            };

            DisplayProduct(p);
            DisplayProduct(b);
            DisplayProduct(s);
            DisplayProduct(ma);
        }

        /// <summary>
        /// Displays product object, or children/derived objects / instances of subtypes
        /// </summary>
        /// <param name="p"></param>
        private static void DisplayProduct(Product p)
        {
            // check at runtime and get compile time support
                // if(p.GetType() == typeof(Book))
                // if(p.GetType().Name == nameof(Book))
            if (p is Book)
            {
                // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/type-testing-and-cast
                // Traditional casting
                //Book temp = (Book)p;

                // New casting style, behaves same as above
                Book temp = p as Book;

                Console.WriteLine($"Check out the book {temp.Description} written by {temp.Author}!\n");
            }

            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }
}