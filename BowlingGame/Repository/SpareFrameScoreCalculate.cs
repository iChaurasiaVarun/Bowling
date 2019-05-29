using BowlingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Repository
{
    class SpareFrameScoreCalculate : AbstractFrameScoreCalculate
    {
        public SpareFrameScoreCalculate(FrameScore frame) : base(frame)
        {
        }

        public override void CalculateBonus(AbstractFrameScoreCalculate consecutiveFirstFrame, AbstractFrameScoreCalculate consecutiveSecondFrame)
        {
            base._frameBonus += consecutiveFirstFrame.frame.FirstChanceScore;
        }
    }
}
