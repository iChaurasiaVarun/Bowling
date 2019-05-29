using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingGame.Models;

namespace BowlingGame.Repository
{
    class StrikeFrameScoreCalculate: AbstractFrameScoreCalculate
    {
        public StrikeFrameScoreCalculate(FrameScore frame) : base(frame)
        {
        }

        public override void CalculateBonus(AbstractFrameScoreCalculate consecutiveFirstFrame, AbstractFrameScoreCalculate consecutiveSecondFrame)
        {
            if (consecutiveFirstFrame is StrikeFrameScoreCalculate)
                base._frameBonus += 10 + consecutiveSecondFrame.frame.FirstChanceScore;
            else
                base._frameBonus += consecutiveFirstFrame.frame.FirstChanceScore + consecutiveFirstFrame.frame.SecondChanceScore;
        }
    }
}
