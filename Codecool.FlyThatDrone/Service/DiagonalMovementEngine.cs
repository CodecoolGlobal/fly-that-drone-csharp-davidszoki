using Codecool.FlyThatDrone.Model;

namespace Codecool.FlyThatDrone.Service;

public class DiagonalMovementEngine : IMovementEngine
{
    private IMovementEngine _movementEngine;

    public DiagonalMovementEngine(IMovementEngine movementEngine)
    {
        _movementEngine = movementEngine;
    }
    public bool Move(Drone drone, string direction)
    {
        switch (direction)
        {
            case "w-a":
                return _movementEngine.Move(drone, "w") && _movementEngine.Move(drone, "a");
            case "w-d":
                return _movementEngine.Move(drone, "w") && _movementEngine.Move(drone, "d");
            case "s-a":
                return _movementEngine.Move(drone, "s") && _movementEngine.Move(drone, "a");
            case "s-d":
                return _movementEngine.Move(drone, "s") && _movementEngine.Move(drone, "d");
            default:
                return false;
        }
    }
}