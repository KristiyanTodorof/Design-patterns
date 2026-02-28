using Ecosystem.Factories;
using Ecosystem.Interfaces;
using Ecosystem.Services;

Console.WriteLine("--- Jungle Ecosystem ---");
IEcosystemFactory jungleFactory = new JungleEcosystemFactory();
EcosystemSimulator jungleSimulator = new EcosystemSimulator(jungleFactory);
jungleSimulator.Simulation();

Console.WriteLine("\n--- Arctic Ecosystem ---");
IEcosystemFactory arcticFactory = new ArcticEcosystemFactory();
EcosystemSimulator arcticSimulator = new EcosystemSimulator(arcticFactory);
arcticSimulator.Simulation();
