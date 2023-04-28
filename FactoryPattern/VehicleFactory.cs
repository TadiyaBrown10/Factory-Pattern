using System;
namespace FactoryPattern
{
	public static class VehicleFactory 
	{

        public static IVehicle GetVehicle(int wheelcount)
        {
            switch (wheelcount)
            {
                case 4:
                    return new Car();
                case 18:
                    return new Truck();
                default:
                    return new Car();
            }
                
            
        }

        internal static void GetVehicle()
        {
            throw new NotImplementedException();
        }
    }
}

