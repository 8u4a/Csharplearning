using System;

namespace VehicleTest
{

    public class Car : ICommonVehicle
    {
              

        
        public void MoveForward()
        {
           
        }

        public void MoveBackwards()
        {
            
        }

         public void UseHonk()
         {
        
         }

        public void UseLights(LightIntensity intensity = LightIntensity.Short)
        {
           if (intensity == LightIntensity.Short)
            {

            }else
            {

            }
        }

        public void StartEngine()
        {
            
        }

        public void StopEngine()
        {
           
        }
    }



}
