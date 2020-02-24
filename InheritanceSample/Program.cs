﻿using System;
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
            #region TournamentEntry Dada Manipulation
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

            Product p = new Product
            {
                Code = "ABC",
                Description = "A generic product",
                Price = 9.99
            };

            Book b = new Book
            {
                Code = "978-1890774943",
                Description = "Murach's C# 2015 6th Edition",
                Price = 46.49,
                Author = "Joel Murach "
            };

            Software s = new Software
            {
                Code = "FQC-09525",
                Description = "Windows 10 Pro",
                Price = 129.99,
                Version = "10.0.18363 Build 18363"
            };

            MobileApplication a = new MobileApplication
            {
                Code = "test",
                Description = "test of subtype",
                Price = 9.99,
                Version = "1.0.0",
                MobileOS = "AppleOS"
            };

            DisplayProduct(p);
            DisplayProduct(b);
            DisplayProduct(s);
            DisplayProduct(a);
        }

        /// <summary>
        /// Displays product object, or children/derived objects / instances of subtypes
        /// </summary>
        /// <param name="p"></param>
        private static void DisplayProduct(Product p)
        {
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }
}