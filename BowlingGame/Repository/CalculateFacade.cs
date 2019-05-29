using BowlingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Repository
{
    public class CalculateFacade : ICalculateFacade
    {
        IFrameProcess frameProcess = null;
        public CalculateFacade(): this(new FrameProcess())
        {
            
        }

        public CalculateFacade(IFrameProcess frameProcess)
        {
            this.frameProcess = frameProcess;
        }
        public int CalculateBowlingScore(List<Frame> frames)
        {
            int score = 0;
            this.frameProcess.AddBonusFrame(this.frameProcess.FramesProcess(frames)).ForEach(frame => score += frame.GetScore());
            return score;
        }

        
    }
}
