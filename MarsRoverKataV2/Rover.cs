using System;
using System.Drawing;

namespace MarsRoverKataV2
{
    public class Rover
    {
        public readonly CardinalPoint CardinalPointFaced;

        public Rover(Grid gridSize, Point startingPoint, CardinalPoint initialDirection)
        {
            CardinalPointFaced = initialDirection;
        }
    }
}
