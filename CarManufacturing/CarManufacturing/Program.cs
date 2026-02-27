using CarManufacturing.Factories;
using CarManufacturing.Interfaces;
using CarManufacturing.Services;

ICarFactory europeanFactory = new EuropeanCarFactory();
CarManufacturingSimulator.SimulateProduction(europeanFactory);

// Simulate Asian car production
ICarFactory asianFactory = new AsianCarFactory();
CarManufacturingSimulator.SimulateProduction(asianFactory);