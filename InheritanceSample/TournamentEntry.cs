using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    /*
     * TournamentEntry should score up to 4 bowling scores.
     * Valid scores could be 0 to 300, inclusive.
     * All 4 games are optional.
     * Track the scratch total; ie sum of scores played up to 4 scores.
     */

    /* ----------
     * Methods:
     *   CalcAvg
     *   CalcScratch
     * ----------
     * Properties:
     *   Score, List<int>
     */

    class TournamentEntry
    {

        public TournamentEntry()
        {
            Games = new List<int>();
        }

        public List<int> Games
        {
            get; private set; 
        }

        public enum GameNumber
            {
                First, Second, Thrid, Fourth
            }

        public void AddGame(int score, GameNumber gameNum)
        {
            throw new NotImplementedException("This method has not yet been implemented");
        }

        public void AddGame(int score)
        {
            if (score < 0 || score > 300)
    	    {
                throw new ArgumentOutOfRangeException("Valid scores are 0 to 300 inclusive.");
            }
            else
            {
                if (Games.Count() < 4)
                {
                    Games.Add(score);
                }
                else
                {
                    throw new ArgumentException("Cannot have more than 4 games!");
                }
            }
        }

        public int GetScratchTotal()
        {
            return Games.Sum();
        }
    }
}
