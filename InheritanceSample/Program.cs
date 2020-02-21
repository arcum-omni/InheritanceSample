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
            TournamentEntry te = new TournamentEntry();
            te.AddGame(225);
            te.AddGame(250);
            te.AddGame(190);
            te.AddGame(275);
            te.AddGame(300);

            //te.AddGame(225, TournamentEntry.GameNumber.First);
            //te.AddGame(250, TournamentEntry.GameNumber.Second);
            //te.AddGame(190, TournamentEntry.GameNumber.Thrid);
            //te.AddGame(275, TournamentEntry.GameNumber.Fourth);
            //te.AddGame(300, TournamentEntry.GameNumber.First);
        }
    }
}
