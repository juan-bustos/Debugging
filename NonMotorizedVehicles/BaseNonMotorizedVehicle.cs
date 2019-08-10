﻿using Enumerations;

namespace NonMotorizedVehicles
{
    public class BaseNonMotorizedVehicle
    {
        private bool isMoving;
        public BaseNonMotorizedVehicle()
        {
            isMoving = false;
        }
        public bool HasPedals { get;set;}
        public int NoOfWheels { get; set; }
        public TerrainType TerrainType { get; set; }

        public bool Moving()
        {
            return this.isMoving;
        }
        public bool Moving(bool isMoving)
        {
            this.isMoving = isMoving;
            return this.isMoving;
        }
    }
}
