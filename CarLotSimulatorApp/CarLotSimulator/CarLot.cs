using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> ParkingLot { get; set; } = new List<Car>();
        public static int _numberofCars;

        public void CheckCars() 
        {
            foreach (var car in ParkingLot) 
            { 
              Console.WriteLine($"This is a {car.Make} {car.Model} made in the year {car.Year}.");
                car.MakeEngineNosie(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
                Console.WriteLine();
            }
        
        }
    
    
    
    
    }
}
