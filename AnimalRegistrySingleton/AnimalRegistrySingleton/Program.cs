using AnimalRegistrySingleton;

Console.WriteLine("===== Animal Registry Example =====");
AnimalRegistry registry1 = AnimalRegistry.GetInstance();
AnimalRegistry registry2 = AnimalRegistry.GetInstance();

Console.WriteLine($"Are registry1 and registry2 the same instance? {registry1 == registry2}");

registry1.RegisterAnimal("Leo", "Lion");
registry1.RegisterAnimal("Charlie", "Cheetah");
registry2.RegisterAnimal("Dumbo", "Elephant");
registry1.RegisterAnimal("Leo", "Tiger"); // Try to register duplicate name

Console.WriteLine($"Charlie is a {registry2.GetAnimalSpecies("Charlie")}");
registry1.ListAllAnimals();
