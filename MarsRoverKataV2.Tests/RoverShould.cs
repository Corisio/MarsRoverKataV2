using System;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;
using NUnit.Framework;

namespace MarsRoverKataV2.Tests
{
    [TestFixture]
    public class RoverShould
    {
        private Grid DefaultGrid { get; set; }
        private Point DefaultPosition { get; set; }
        private CardinalPoint DefaultCardinalPoint { get; set; }
        private Rover DefaultRover { get; set; }

        [SetUp]
        public void SetUp()
        {
            DefaultGrid = new Grid(5, 5);
            DefaultPosition = new Point();
            DefaultCardinalPoint = CardinalPoint.North;
            DefaultRover = new Rover(DefaultGrid, DefaultPosition, DefaultCardinalPoint);
        }

        [TestCase(CardinalPoint.North)]
        [TestCase(CardinalPoint.East)]
        [TestCase(CardinalPoint.South)]
        [TestCase(CardinalPoint.West)]
        public void BeFacingTheCorrectCardinalPoint_WhenInitialised(CardinalPoint startingCardinalPoint)
        {
            var rover = new Rover(DefaultGrid, DefaultPosition, startingCardinalPoint);

            Assert.AreEqual(startingCardinalPoint, rover.CardinalPointFaced);
        }

        [Test]
        public void ContainTheSameGridWithWhichItWasInitialised()
        {
            var grid = new Grid(2, 3);
            var rover = new Rover(grid, DefaultPosition, DefaultCardinalPoint);

            Assert.AreEqual(new Grid(grid.SizeX, grid.SizeY), rover.Grid);
        }

        [Test]
        public void ContainTheSamePositionWithWhichItWasInitialised()
        {
            var startingPosition = new Point(1, 2);
            var rover = new Rover(DefaultGrid, startingPosition, DefaultCardinalPoint);

            Assert.AreEqual(new Point(startingPosition.X, startingPosition.Y), rover.Position);
        }

        [Test]
        public void ThrowException_WhenReceivingNullMovementArray()
        {
            Assert.Throws<ArgumentNullException>(() => DefaultRover.Execute((string[])null));
        }

        [Test]
        public void IncrementYPositionInOne_WhenFacingNorthAndExecutingF()
        {
            DefaultRover.Execute(new string[] { "f" });
            Assert.AreEqual(1, DefaultRover.Position.Y);
        }

        [Test]
        public void DecrementYPositionInOne_WhenFacingSouthAndExecutingF()
        {
            DefaultRover.CardinalPointFaced = CardinalPoint.South;
            DefaultRover.Execute(new string[] { "f" });
            Assert.AreEqual(-1, DefaultRover.Position.Y);
        }

        [Test]
        public void IncrementXPositionInOne_WhenFacingEastAndExecutingF()
        {
            DefaultRover.CardinalPointFaced = CardinalPoint.East;
            DefaultRover.Execute(new string[] { "f" });
            Assert.AreEqual(1, DefaultRover.Position.X);
        }

        [Test]
        public void DecrementXPositionInOne_WhenFacingWestAndExecutingF()
        {
            DefaultRover.CardinalPointFaced = CardinalPoint.West;
            DefaultRover.Execute(new string[] { "f" });
            Assert.AreEqual(-1, DefaultRover.Position.X);
        }
    }
}
