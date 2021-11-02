using System;

namespace CarsApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("DMC","De Lorean",100,100,100,1,50,1994,"Gray");
            Car car2 = new Car("Mercedes","Aclass",100,100,100,1,50,1994,"Black");
            Car car3 = new Car("Mercedes", "Bclass",100,100,100,1,50,1994,"Gray");
            Car car4 = new Car("Mercedes", "Cclass",100,100,100,1,50,1994,"Gray");

            Car[] cars = new Car[] { car1, car2, car3, car4 };

            Car[] arr = GetCarsByBrandName("mer", cars);

            foreach (var item in arr)
            {
                Console.WriteLine("-------------------------------");
                item.ShowInfo();
            }





        }
        public static Car[] GetCarsByBrandName(string brand, Car[] cars)
        {
            Car[] arr = new Car[0];



            foreach (var car in cars)
            {
                if (car.Brand.ToLower().Contains(brand.ToLower()))
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = car;
                }
            }
            return arr;

            
        }
    }
}
