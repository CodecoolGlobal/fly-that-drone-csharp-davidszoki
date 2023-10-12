using Codecool.FlyThatDrone.Model;

namespace Codecool.FlyThatDrone.Service;

public class MovementEngine : IMovementEngine
{
    public bool Move(Drone drone, string direction)
    {
        switch (direction)
        {
            case "w":
                drone.Position = new Position(drone.Position.X, drone.Position.Y + 1, drone.Position.Z);
                return true;
            case "s":
                drone.Position = new Position(drone.Position.X, drone.Position.Y - 1, drone.Position.Z);
                return true;
            case "a":
                drone.Position = new Position(drone.Position.X - 1, drone.Position.Y, drone.Position.Z);
                return true;
            case "d":
                drone.Position = new Position(drone.Position.X + 1, drone.Position.Y, drone.Position.Z);
                return true;
            case "q":
                drone.Position = new Position(drone.Position.X, drone.Position.Y, drone.Position.Z + 1);
                return true;
            case "e":
                drone.Position = new Position(drone.Position.X, drone.Position.Y, drone.Position.Z - 1);
                return true;
           default:
               return false;
        }
    }
}