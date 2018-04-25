using System;

namespace MarsRoverKataV2
{
    public struct Grid
    {
        public int SizeX { get; }
        public int SizeY { get; }

        public Grid(int sizeX, int sizeY)
        {
            SizeX = sizeX;
            SizeY = sizeY;
        }

    }
}
