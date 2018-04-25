using System.Drawing;

namespace MarsRoverKataV2
{
    public interface IMovementCommand
    {
        Point Execute(Point currentPosition, CardinalPoint currentlyFacedCardinalPoint);
    }
}