using CarRegistrySingleton;

Console.WriteLine("===== Car Registry Example =====");
CarRegistry registry1 = CarRegistry.GetInstance();
CarRegistry registry2 = CarRegistry.GetInstance();

Console.WriteLine($"Are registry1 and registry2 the same instance? {registry1 == registry2}");

registry1.RegisterCar("Mercedes", "Kristiayn");
registry1.RegisterCar("BMW", "Ivo");
registry2.RegisterCar("Skoda", "Krasen");
registry1.RegisterCar("Mercedes", "Martin"); // Try to register duplicate name

Console.WriteLine($"The owner of the mercedes is {registry2.GetCarModels("Mercedes")}");
registry1.ListAllCars();