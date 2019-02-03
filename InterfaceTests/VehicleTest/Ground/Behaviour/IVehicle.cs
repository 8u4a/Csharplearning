using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTest
{
    /// <summary>
    /// common functionality for all vehicles: they can move and use their engines
    /// </summary>
    public interface IVehicle : IFunctionalEngine, IMobility
    {
        
    }
}
