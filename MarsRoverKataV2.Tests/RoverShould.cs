using System;
using System.Drawing;
using NUnit.Framework;

namespace MarsRoverKataV2.Tests
{
    [TestFixture]
    public class RoverShould
    {
        [TestCase(CardinalPoint.North)]
        [TestCase(CardinalPoint.East)]
        [TestCase(CardinalPoint.South)]
        [TestCase(CardinalPoint.West)]
        public void BeFacingTheCorrectCardinalPoint_WhenInitialised(CardinalPoint startingCardinalPoint)
        {
            var grid = new Grid(5, 5);
            var startingPosition = new Point();
            var rover = new Rover(grid, startingPosition, startingCardinalPoint);

            Assert.AreEqual(startingCardinalPoint, rover.CardinalPointFaced);
        }

        [Test]
        public void ContainTheSameGridWithWhichItWasInitialised()
        {
            var grid = new Grid(2, 3);
            var startingPosition = new Point();
            var rover = new Rover(grid, startingPosition, CardinalPoint.North);

            Assert.AreEqual(new Grid(grid.SizeX, grid.SizeY), rover.Grid);
        }

        [Test]
        public void ContainTheSamePositionWithWhichItWasInitialised()
        {
            var grid = new Grid(5, 5);
            var startingPosition = new Point(1, 2);
            var rover = new Rover(grid, startingPosition, CardinalPoint.North);

            Assert.AreEqual(new Point(startingPosition.X, startingPosition.Y), rover.Position);
        }
    }
}
