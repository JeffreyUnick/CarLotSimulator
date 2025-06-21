using System;
using System.Diagnostics;
using System.Collections.Generic;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();

            firstCar.Make = "BMW";
            firstCar.Year = 2025;
            firstCar.Model = "XM";
            firstCar.EngineNoise = "V12";
            firstCar.HonkNoise = "BMW HONK";
            firstCar.IsDrivable = true;
            
            firstCar.MakeEngineNoise("VROOOM TO-TO-TO-TO-TO-TO !!!");
            firstCar.MakeHonkNoise("Piiiii\n");

            Car secondCar = new Car()
            {
                Make = "TESLA",
                Year = 2025,
                Model = "Y",
                EngineNoise = "All Electric",
                HonkNoise = "Tesla HONK",
                IsDrivable = true,
            };
            
            secondCar.MakeEngineNoise("......");
            secondCar.MakeHonkNoise("tiiiim-tiiiim-tiiiim-tiiiim\n");

            Car thirdCar = new Car("TOYOTA", 2025, "RAV4", "Toyota RAV4", 
                "Toyota Honk", true);
           
            
            thirdCar.MakeEngineNoise("Vrooom");
            thirdCar.MakeHonkNoise("Piim-piim-piim-piim\n");
            
            CarLot bernysCarLot = new CarLot();
            
            bernysCarLot._listOfCars.Add (firstCar);
            bernysCarLot._listOfCars.Add (secondCar);
            bernysCarLot._listOfCars.Add (thirdCar);
            
            bernysCarLot.PrintingCarsInfos(bernysCarLot._listOfCars);
            
        }
    }
}
