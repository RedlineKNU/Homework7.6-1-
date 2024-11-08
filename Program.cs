namespace FactoryMethod
{
    public abstract class Vehicle
    {
        public abstract void Drive();
    }

    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a car...");
        }
    }

    public class Motorcycle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Riding a motorcycle...");
        }
    }

    public abstract class VehicleFactory
    {
        public abstract Vehicle CreateVehicle();
    }

    public class CarFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new Car();
        }
    }

    public class MotorcycleFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new Motorcycle();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory carFactory = new CarFactory();
            Vehicle car = carFactory.CreateVehicle();
            car.Drive();

            VehicleFactory motorcycleFactory = new MotorcycleFactory();
            Vehicle motorcycle = motorcycleFactory.CreateVehicle();
            motorcycle.Drive();

            Console.ReadKey();
        }
    }
}
