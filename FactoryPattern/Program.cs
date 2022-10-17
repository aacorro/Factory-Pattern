namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numWheels;
            bool userInput = false;

            do
            {
                Console.WriteLine("Enter the amount of tires for the vehicle you desire to build:");
                 userInput = int.TryParse(Console.ReadLine(), out numWheels);
            } while (userInput == false);


            Console.WriteLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(numWheels);
            vehicle.Drive();

        }
    }
}