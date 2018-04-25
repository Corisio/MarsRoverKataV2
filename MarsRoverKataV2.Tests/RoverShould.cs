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
            var rover = new Rover(startingCardinalPoint);

            Assert.AreEqual(startingCardinalPoint, rover.CardinalPointFaced);
        }
    }
}
