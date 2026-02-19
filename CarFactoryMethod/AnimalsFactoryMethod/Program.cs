using AnimalsFactoryMethod.Factories;

AnimalFactory tiger = new TigerFactory();
AnimalFactory panda = new PandaFactory();
AnimalFactory giraffe = new GiraffeFactory();

tiger.SeeAnimal();
panda.SeeAnimal();
giraffe.SeeAnimal();
