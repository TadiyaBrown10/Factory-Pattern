using System;
namespace FactoryPattern
{
	public class Truck : IVehicle
	{
		public Truck()
		{
		}

        public void Drive()
        {
            Console.WriteLine("This truck is on the go...");
        }
    }
}

