using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Models
{
    public interface IFrameProcess
    {
        List<AbstractFrameScoreCalculate> FramesProcess(List<Frame> frames);
        List<AbstractFrameScoreCalculate> AddBonusFrame(List<AbstractFrameScoreCalculate> abstractFrameScoreCalculates);
    }
}
