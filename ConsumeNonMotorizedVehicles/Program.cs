﻿using Enumerations;
using INonMotorizedVehicles;
using NonMotorizedVehicles;
using Structures;
using System;

namespace ConsumeNonMotorizedVehicles
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Bicycle bike = new Bicycle()
                {
                    TerrainType = TerrainType.Beach,
                    NoOfWheels = 2
                };
                Tricycle trike = new Tricycle
                {
                    TerrainType = TerrainType.City,
                    NoOfWheels = 3
                };
                Bicycle bikeTwin = bike;
                {
                    bikeTwin.TerrainType = TerrainType.AllTerrain;
                    Console.WriteLine($"bike has terrain type {bike.TerrainType}");
                }
                Tricycle trikeTwin = trike;
                {
                    trikeTwin.TerrainType = TerrainType.Mountain;
                    Console.WriteLine($"trike has terrain type {trike.TerrainType}");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
