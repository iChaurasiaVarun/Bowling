using BowlingGame.Models;
using BowlingGame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    /// <summary>
    /// Starter class of bowling application
    /// </summary>
    class Program
    {
        private static readonly List<Frame> frames = new List<Frame>();

        static void Main(string[] args)        {
            
            Console.WriteLine("Enter frame chance by comma seperated:");
            Console.WriteLine("Eg.,");
            Console.WriteLine("Input for first frame x");
            Console.WriteLine("Input for second frame 9,/");
            Console.WriteLine("Input for third frame 5,/");
            Console.WriteLine("Input for fourth frame 7,2");
            Console.WriteLine("so on...");
            Console.WriteLine("----------------------------");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter Frame {0} :", i + 1);
                frames.Add(Program.CreateFrame( Console.ReadLine()));
            }
            Console.WriteLine("Your score is {0} : ", new CalculateFacade().CalculateBowlingScore(frames));
            Console.Read();
        }

        /// <summary>
        /// Transform user console input to frames
        /// </summary>
        /// <param name="frameInput"></param>
        /// <returns></returns>
        private static Frame CreateFrame(string frameInput)
        {
            Frame frame = null;
            string[] frameChances = frameInput.Split(',');
            if(frameChances.Count() == 1)
            {
                frame = new Frame(frameChances[0], "0");
            }
            if(frameChances.Count() == 2)
            {
                frame = new Frame(frameChances[0], frameChances[1]); 
            }
            else if(frameChances.Count() == 3)
            {
                frame = new Frame(frameChances[0], frameChances[1], frameChances[2]);
            }
            return frame;
        }
    }
}
