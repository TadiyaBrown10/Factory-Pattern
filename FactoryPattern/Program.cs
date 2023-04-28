namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there! Enter the number of tires for your dream ride:");

            int tireCount;
            var input = int.TryParse(Console.ReadLine(), out tireCount);

            var vehicle = VehicleFactory.GetVehicle(tireCount);
            vehicle.Drive();
        }
    }
}
