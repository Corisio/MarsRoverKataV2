using System.Drawing;

namespace MarsRoverKataV2
{
    public class ForwardMovementCommand : IMovementCommand
    {
        public Point Execute(Point currentPosition, CardinalPoint currentlyFacedCardinalPoint)
        {
            int modifier = 1;

            if (currentlyFacedCardinalPoint == CardinalPoint.West || currentlyFacedCardinalPoint == CardinalPoint.South)
            {
                modifier *= -1;
            }

            if (currentlyFacedCardinalPoint == CardinalPoint.North ||
                currentlyFacedCardinalPoint == CardinalPoint.South)
            {
                return new Point(currentPosition.X, currentPosition.Y + modifier);
            }

            return new Point(currentPosition.X + modifier, currentPosition.Y);
        }
    }
}
