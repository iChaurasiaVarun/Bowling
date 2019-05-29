using BowlingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Repository
{
    class NormalFrameScoreCalculate : AbstractFrameScoreCalculate
    {
        public NormalFrameScoreCalculate(FrameScore frame) : base(frame)
        {
        }
    }
}
