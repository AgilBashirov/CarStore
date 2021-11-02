using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApps
{
    class Car:Vehicle
    {
        private string _brand;
        public string Brand {
            get
            {
                return _brand;
            }
            set
            {
                if (value.Length < 10)
                {
                    _brand = value;
                }
                else
                {
                    Console.WriteLine("brandin uzunlugu 10dan kicikdir!");
                }
            }
        }

        private string _model;

        public Car(string brand,  string model, int millage, int globalMillage, int fuelCapacity, int fuelFor1Km, int currentFuel, int year, string color):base(year,color)
        {
           
            Brand = brand;
            Model = model;
            Millage = millage;
            GlobalMillage = globalMillage;
            FuelCapacity = fuelCapacity;
            FuelFor1Km = fuelFor1Km;
            CurrentFuel = currentFuel;
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value.Length < 10)
                {
                    _model = value;
                }
            }
        }

        public int Millage { get; private set; }
        public int GlobalMillage { get; private set; }

        public int FuelCapacity { get; }
        public int FuelFor1Km { get; }
        public int CurrentFuel { get; private set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Brand          : {Brand}");
            Console.WriteLine($"Model          : {Model}");
            Console.WriteLine($"Millage        : {Millage}");
            Console.WriteLine($"Global millage : {GlobalMillage}");
            Console.WriteLine($"Fuel capasity  : {FuelCapacity}");
            Console.WriteLine($"Fuel for 1 km  : {FuelFor1Km}");
            Console.WriteLine($"Current fuel   : {CurrentFuel}");
            

        }

        public bool AddFuel(int fuel)
        {
            bool isOk = false;

            if (fuel + CurrentFuel <= FuelCapacity)
            {
                CurrentFuel += fuel;
                isOk = true;
                return isOk;
            }


            return isOk;
        }

        public bool Drive(int km)
        {
            int nededFuel = km * FuelFor1Km;

            if (nededFuel <= CurrentFuel)
            {
                Millage += km;
                GlobalMillage += km;
                CurrentFuel -= nededFuel;
                return true;

            }
            else
            {
                return false;
            }
        }

        public void ResetMillage()
        {
            Millage = 0;
        }

        
    }
}
