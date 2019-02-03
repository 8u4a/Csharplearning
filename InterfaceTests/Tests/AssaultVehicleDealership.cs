using System;
using System.Collections.Generic;
using System.Text;
using VehicleTest;

namespace Tests
{
    public class AssaultVehicleDealership
    {
        public List<ICombatVehicle> VehiclesStock { get; set; }
        public AssaultVehicleDealership()
        {
            VehiclesStock = new List<ICombatVehicle>();
        }
    }
}
