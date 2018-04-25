using System;
using System.Drawing;

namespace MarsRoverKataV2
{
    public class Rover
    {
        public Grid Grid { get; }
        public Point Position { get; }
        public CardinalPoint CardinalPointFaced { get; }

        public Rover(Grid gridSize, Point startingPoint, CardinalPoint initialDirection)
        {
            Grid = gridSize;
            Position = startingPoint;
            CardinalPointFaced = initialDirection;
        }
    }
}
