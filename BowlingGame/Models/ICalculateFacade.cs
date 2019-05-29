using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Models
{
    /// <summary>
    /// interface to provide calculation of game score
    /// </summary>
    public interface ICalculateFacade
    {
        int CalculateBowlingScore(List<Frame> frames);
    }
}
