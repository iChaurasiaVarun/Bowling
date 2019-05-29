using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Models
{
    /// <summary>
    /// Abstract Class for calculating the different types of frames score
    /// </summary>
    public abstract class AbstractFrameScoreCalculate
    {
        protected int _frameBonus;
        public FrameScore frame;
        public AbstractFrameScoreCalculate(FrameScore frame)
        {
            this.frame = frame;
        }

        /// <summary>
        /// Method to get score of frame
        /// </summary>
        /// <returns></returns>
        public int GetScore() { return frame.FirstChanceScore + frame.SecondChanceScore + _frameBonus; }

        /// <summary>
        /// Method to calculate bonus in case of spare and strike frame
        /// </summary>
        /// <param name="consecutiveFirstFrame"></param>
        /// <param name="consecutiveSecondFrame"></param>
        public virtual void CalculateBonus(AbstractFrameScoreCalculate consecutiveFirstFrame, AbstractFrameScoreCalculate consecutiveSecondFrame) { }

    }
}
