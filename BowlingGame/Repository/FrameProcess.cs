using BowlingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Repository
{
    /// <summary>
    /// frame processor
    /// </summary>
    public class FrameProcess : IFrameProcess
    {
        private int frameCount = 0;

        /// <summary>
        /// to add bonus frame to handle strike and spare scenario
        /// </summary>
        /// <param name="abstractFrameScoreCalculates"></param>
        /// <returns></returns>
        public List<AbstractFrameScoreCalculate> AddBonusFrame(List<AbstractFrameScoreCalculate> abstractFrameScoreCalculates)
        {
            for (int i = 0; i < 10; i++)
                abstractFrameScoreCalculates[i].CalculateBonus(abstractFrameScoreCalculates[i + 1], abstractFrameScoreCalculates[i + 2]);
            return abstractFrameScoreCalculates;
        }

        /// <summary>
        /// To convert user input frames to scores frame
        /// </summary>
        /// <param name="frames"></param>
        /// <returns></returns>
        public List<AbstractFrameScoreCalculate> FramesProcess(List<Frame> frames)
        {
            List<AbstractFrameScoreCalculate> abstractFrameScoreCalculates = new List<AbstractFrameScoreCalculate>();
            frames.ForEach(frame => {
                frameCount += 1;
                abstractFrameScoreCalculates.Add(frameCount == 10 ? this.GetLastFrameScore(frame) : this.GetScoreCalculate(frame));
                });
            abstractFrameScoreCalculates.Add(this.GetScoreCalculate(new Frame("0", "0")));
            abstractFrameScoreCalculates.Add(this.GetScoreCalculate(new Frame("0", "0")));
            return abstractFrameScoreCalculates;
        }

        /// <summary>
        /// To generate appropriate concerete class for calculating the score
        /// </summary>
        /// <param name="frame"></param>
        /// <returns></returns>
        private AbstractFrameScoreCalculate GetScoreCalculate(Frame frame)
        {
            if (frame.FirstChance == "x")
                return new StrikeFrameScoreCalculate(new FrameScore(10, 0));

            if (frame.SecondChance == "/")
                return new SpareFrameScoreCalculate(new FrameScore(Convert.ToInt16(frame.FirstChance), 10 - Convert.ToInt16(frame.FirstChance)));

            return new NormalFrameScoreCalculate(new FrameScore( Convert.ToInt16(frame.FirstChance), frame.SecondChance == "-" ? 0 : Convert.ToInt16(frame.SecondChance)));
        }
        
        /// <summary>
        /// to handle last frame user input 
        /// </summary>
        /// <param name="frame"></param>
        /// <returns></returns>
        private AbstractFrameScoreCalculate GetLastFrameScore(Frame frame)
        {
            FrameScore frameScore = new FrameScore();
            if(frame.FirstChance == "x" || frame.FirstChance != "/" || frame.FirstChance == "-")
            {
                if (frame.FirstChance == "x")
                    frameScore.FirstChanceScore = 10;
                else if (frame.FirstChance == "-")
                    frameScore.FirstChanceScore = 0;
                else
                    frameScore.FirstChanceScore = Convert.ToInt32(frame.FirstChance); 
            }

            if(frame.SecondChance == "/" || frame.SecondChance == "x")
            {
                if (frame.SecondChance == "x")
                    frameScore.SecondChanceScore = 10;
                else
                    frameScore.SecondChanceScore = 10 - frameScore.FirstChanceScore;
            }
            else
            {
                frameScore.SecondChanceScore = frame.SecondChance == "-" ? 0 : Convert.ToInt16(frame.SecondChance);
            }

            if (frame.ThirdChance == "/" || frame.ThirdChance == "x")
            {
                if (frame.ThirdChance == "x")
                    frameScore.ThirdChanceScore = 10;
                else
                    frameScore.ThirdChanceScore = 10 - frameScore.SecondChanceScore;
            }
            else
            {
                frameScore.ThirdChanceScore = frame.ThirdChance == "-" ? 0 : Convert.ToInt16(frame.ThirdChance);
            }

            return new FinalFrameScoreCalculate(frameScore);
        }
    }
}
