using System;
using System.Collections.Generic;
using BowlingGame.Models;
using BowlingGame.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameTest
{
    [TestClass]
    public class BowlingGameTest
    {
        List<Frame> frames = null;
        ICalculateFacade calculateFacade = null;
        IFrameProcess frameProcess = null;

        /// <summary>
        /// for initialization the resources
        /// </summary>
        [TestInitialize]
        public void InitializeFrame()
        {
            this.frameProcess = new FrameProcess();
            this.calculateFacade = new CalculateFacade(this.frameProcess);
        }

        /// <summary>
        /// Top check result for valid input
        /// </summary>
        [TestMethod]
        public void CheckForValidInput()
        {
            this.frames = new List<Frame>();
            this.frames.Add(new Frame("x", ""));
            this.frames.Add(new Frame("9", "/"));
            this.frames.Add(new Frame("5", "/"));
            this.frames.Add(new Frame("7", "2"));
            this.frames.Add(new Frame("x", ""));
            this.frames.Add(new Frame("x", ""));
            this.frames.Add(new Frame("x", ""));
            this.frames.Add(new Frame("9", "-"));
            this.frames.Add(new Frame("8", "/"));
            this.frames.Add(new Frame("9", "/", "x"));
            Assert.AreEqual(this.calculateFacade.CalculateBowlingScore(this.frames), 187);
        }

        /// <summary>
        /// For cleanup the used resources
        /// </summary>
        [TestCleanup]
        public void CleanUp()
        {
            this.frames = null;
            this.frameProcess = null;
            this.calculateFacade = null;
        }
    }
}
