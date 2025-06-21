using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
   public List<Car> _listOfCars = new List<Car>();

   public void PrintingCarsInfos(List<Car>listOfCars)
   {
     foreach(Car car in listOfCars)
     {
         Console.WriteLine($"{car.Make}, {car.Model}, {car.Year}");
     }
   }
}