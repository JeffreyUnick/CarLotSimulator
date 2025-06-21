using System;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDrivable { get; set; }

    public void MakeEngineNoise(string engine)
    {
        Console.WriteLine($"The engine noise of the {Make} is : {engine}");
    }

    public void MakeHonkNoise(string honk)
    {
        Console.WriteLine($"The honk noise of the {Make} is : {honk}");
    }

    public Car()
    {
        
    }

    public Car(string make, int year, string model, string engineNoise, string honkNoise, bool isDrivable)
    {
        Make = make;
        Year = year;
        Model = model;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        IsDrivable = isDrivable;
    }
}