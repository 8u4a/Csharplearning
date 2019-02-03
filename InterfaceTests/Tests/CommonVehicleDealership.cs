using System.Collections.Generic;
using VehicleTest;

namespace Tests
{
    class CommonVehicleDealership
    {
        public List<ICommonVehicle> VehiclesStock { get; set; }
        

        public CommonVehicleDealership()
        {
            VehiclesStock = new List<ICommonVehicle>();
        }
    }
}
