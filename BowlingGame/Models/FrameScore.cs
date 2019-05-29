using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Models
{
    /// <summary>
    /// Class to handle frame score chance wise
    /// </summary>
    public class FrameScore
    {
        internal int FirstChanceScore;
        internal int SecondChanceScore;
        internal int ThirdChanceScore;

        public FrameScore()
        {

        }
        internal FrameScore(int firstChanceScore, int secondChanceScore)
        {
            this.FirstChanceScore = firstChanceScore;
            this.SecondChanceScore = secondChanceScore;
        }

        public FrameScore(int firstChanceScore, int secondChanceScore, int thirdChanceScore): this(firstChanceScore, secondChanceScore)
        {
            this.ThirdChanceScore = thirdChanceScore;
        }
    }
}
