using Enumerations;
using INonMotorizedVehicles;


namespace Structures
{
    public struct Tricycle : INonMotorizedVehicle
    {
        public TerrainType TerrainType { get; set; }
        public int NoOfWheels { get; set; }
        public string Brakes { get; set; }
        public bool HasPedals { get; set; }
        public bool Moving()
        {
            throw new System.NotImplementedException();
        }

        public bool Moving(bool isMoving)
        {
            throw new System.NotImplementedException();
        }
    }
}
