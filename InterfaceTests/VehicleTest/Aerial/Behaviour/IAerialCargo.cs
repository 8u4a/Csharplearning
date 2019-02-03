namespace VehicleTest
{
    public interface IAerialCargo : IAerialVehicle, ICombatVehicle
    {
        void LoadCargo();
        void UnloadCargo();
    }
}
