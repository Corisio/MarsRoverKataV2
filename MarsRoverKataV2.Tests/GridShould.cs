using System;
using NUnit.Framework;

namespace MarsRoverKataV2.Tests
{
    [TestFixture]
    public class GridShould
    {
        [TestCase(0, 5)]
        [TestCase(5, 0)]
        [TestCase(0, 0)]
        public void ThrowException_WhenInitialisedWithZeroInAnyDimension(int sizeX, int sizeY)
        {
            Assert.Throws<ArgumentException>(() => new Grid(sizeX, sizeY));
        }

        [Test]
        public void BeInitializedWithTheSpecifiedValues()
        {
            var sizeX = 5;
            var sizeY = 5;
            var grid = new Grid(sizeX, sizeY);
            Assert.AreEqual(sizeX, grid.SizeX);
            Assert.AreEqual(sizeY, grid.SizeY);
        }
    }
}
