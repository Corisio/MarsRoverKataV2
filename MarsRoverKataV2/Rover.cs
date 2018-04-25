using System;
using System.Collections.Generic;
using System.Drawing;

namespace MarsRoverKataV2
{
    public class Rover
    {
        public Grid Grid { get; }
        public Point Position { get; protected set; }
        public CardinalPoint CardinalPointFaced { get; protected internal set; }

        private static Dictionary<string, IMovementCommand> MovementCommands { get; } =
            new Dictionary<string, IMovementCommand>()
            {
                {"f", new ForwardMovementCommand()}
            };

        public Rover(Grid gridSize, Point startingPoint, CardinalPoint initialDirection)
        {
            Grid = gridSize;
            Position = startingPoint;
            CardinalPointFaced = initialDirection;
        }

        public void Execute(string[] commands)
        {
            GuardAgainstNull(commands);

            foreach (var command in commands)
            {
                Position = MovementCommands[command].Execute(Position, CardinalPointFaced);
            }
        }

        private void GuardAgainstNull(string[] commands)
        {
            if (commands == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
