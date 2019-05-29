using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Models
{
    public class Frame
    {
        public string FirstChance { get; set; }
        public string SecondChance { get; set; }
        public string ThirdChance { get; set; }
        public Frame(string firstChance, string secondChance)
        {
            this.FirstChance = firstChance;
            this.SecondChance = secondChance;
        }

        public Frame(string firstChance, string secondChance, string thirdChance): this(firstChance, secondChance)
        {
            this.ThirdChance = thirdChance;
        }
        public Frame()
        {

        }

    }
}
