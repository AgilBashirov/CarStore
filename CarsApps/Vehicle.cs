using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApps
{
    class Vehicle
    {
        private int _year;
        public int Year {
            get
            {
                return _year;
            }
            set
            {
                if (value >= 1950)
                {
                    _year = value;
                }
                else
                {
                    Console.WriteLine("daxil edilen il 1950den kicikdir!");
                }
            }
        }

        private string _color;
        public string Color {
            get
            {
                return _color;
            }
            set
            {
                if (value.Length<10)
                {
                    _color = value;
                }
            }
       }

        public Vehicle(int year, string color)
        {
            Year = year;
            Color = color;
        }

        public virtual void ShowInfo ()
        {
            Console.WriteLine($"Color : {Color} \nYear : {Year}");
        }
    }
}
