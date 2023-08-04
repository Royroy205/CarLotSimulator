using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() 
        {    
            CarCreated();
            CarLot._numberofCars ++;
        
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable) 
        {

            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            CarCreated();
            CarLot._numberofCars++;
        
        
        }
        
        
        
        
        
        
        
      public int Year { get; set; }

      public string Make { get; set; } 

      public string Model { get; set; }

      public string EngineNoise { get; set; }

      public string HonkNoise { get; set; }

      public bool IsDriveable { get; set; }

        public void MakeEngineNosie(string engineNosie) 
        {
            
            EngineNoise = engineNosie;  
            Console.WriteLine($"{Make} {Model} has an engine noise that sounds like {EngineNoise}");



        }

        public void MakeHonkNoise(string honkNoise) 
        {

            HonkNoise = honkNoise;
            Console.WriteLine($"{Make} {Model} has an honk noise that sounds like {honkNoise}");


        }

        public static void CarCreated() 
        {

            Console.WriteLine("Car was created");
        
        }










    }
}
