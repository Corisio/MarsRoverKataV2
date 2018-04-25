using System;

namespace MarsRoverKataV2
{
    public struct Grid
    {
        public int SizeX { get; }
        public int SizeY { get; }

        public Grid(int sizeX, int sizeY) : this()
        {
            GuardAgainstZero(sizeX);
            GuardAgainstZero(sizeY);
            SizeX = sizeX;
            SizeY = sizeY;
        }

        private void GuardAgainstZero(int value)
        {
            if (value == 0)
            {
                throw new ArgumentException("Value cannot be zero");
            }
        }

    }
}
