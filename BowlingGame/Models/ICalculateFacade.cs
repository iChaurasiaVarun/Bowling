using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Models
{
    public interface ICalculateFacade
    {
        int CalculateBowlingScore(List<Frame> frames);
    }
}
