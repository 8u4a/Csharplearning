using AnimalBehaviourTests;
using InterfaceTests;
using System;
using VehicleTest;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // var interfaceTest = new InterfaceTest();
            // interfaceTest.PublicProperty = 1;

            //// var dog = new AnimalTests();
            //// dog.Bark();
            // AnimalTests.Run();

            var newCar = new Car();
            newCar.StartEngine();
            newCar.StopEngine();
            newCar.MoveBackwards();
            newCar.MoveForward();
            newCar.UseLights();
            newCar.UseLights(LightIntensity.Long);


            var tankHank = new Tank();
            tankHank.StartEngine();
            tankHank.ShootProjectile();

            var bicyclePegas = new ElectricBicycle();
            bicyclePegas.StartEngine();


                        

            var dealerBuzesti = new CommonVehicleDealership();
            dealerBuzesti.VehiclesStock.Add(newCar);
            //dealerBuzesti.Vehicles.Add(tankHank);
            dealerBuzesti.VehiclesStock.Add(bicyclePegas);


            var chopper = new Helicopter();
            var airTransport = new CargoPlane();
            var airFighter = new JetFighter();

            var dealerMilitari = new AssaultVehicleDealership();
            dealerMilitari.VehiclesStock.Add(tankHank);
            dealerMilitari.VehiclesStock.Add(chopper);
            dealerMilitari.VehiclesStock.Add(airFighter);
            dealerMilitari.VehiclesStock.Add(airTransport);
            

            var countMilitariDealershipVehicles = dealerMilitari.VehiclesStock.Count;

            
            var countBuzestiDealershipVehicle = dealerBuzesti.VehiclesStock.Count;


            //var dealerMilitari = new DealerShip();
            //dealerBuzesti
        }
    }
}
