using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Models
{
    /// <summary>
    /// interface to provide frame data process
    /// </summary>
    public interface IFrameProcess
    {
        /// <summary>
        /// To calculate the frame count
        /// </summary>
        /// <param name="frames"></param>
        /// <returns></returns>
        List<AbstractFrameScoreCalculate> FramesProcess(List<Frame> frames);

        /// <summary>
        /// to calculate the bonus of frame 
        /// </summary>
        /// <param name="abstractFrameScoreCalculates"></param>
        /// <returns></returns>
        List<AbstractFrameScoreCalculate> AddBonusFrame(List<AbstractFrameScoreCalculate> abstractFrameScoreCalculates);
    }
}
