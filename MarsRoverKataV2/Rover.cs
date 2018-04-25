using System;

namespace MarsRoverKataV2
{
    public class Rover
    {
        public readonly CardinalPoint CardinalPointFaced;

        public Rover(CardinalPoint initialDirection)
        {
            CardinalPointFaced = initialDirection;
        }
    }
}
