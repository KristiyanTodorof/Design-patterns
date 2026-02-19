using CarFactoryMethod.Factories;

VehicleFactory carFactory = new CarFactory();
VehicleFactory motorcycleFactory = new MotorcycleFactory();
VehicleFactory bicycleFactory = new BicycleFactory();

Console.WriteLine("Using Car Factory:");
carFactory.DeliverVehicle();

Console.WriteLine("Using Motorcycle Factory:");
motorcycleFactory.DeliverVehicle();

Console.WriteLine("Using Bicycle Factory:");
bicycleFactory.DeliverVehicle();
