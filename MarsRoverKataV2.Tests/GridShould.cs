using NUnit.Framework;

namespace MarsRoverKataV2.Tests
{
    [TestFixture]
    public class GridShould
    {
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
