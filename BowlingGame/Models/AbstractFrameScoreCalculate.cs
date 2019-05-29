using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Models
{
    public abstract class AbstractFrameScoreCalculate
    {
        protected int _frameBonus;
        public FrameScore frame;
        public AbstractFrameScoreCalculate(FrameScore frame)
        {
            this.frame = frame;
        }

        public int GetScore() { return frame.FirstChanceScore + frame.SecondChanceScore + _frameBonus; }

        public virtual void CalculateBonus(AbstractFrameScoreCalculate consecutiveFirstFrame, AbstractFrameScoreCalculate consecutiveSecondFrame) { }

    }
}
