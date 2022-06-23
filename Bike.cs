using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    public class Bike : ITransport
    {
        public string Brand { get; set; }
        public float Speed { get; set; }


        public Bike(string brand, float speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public float CalculateDrivingTime(float distance)
        {
            return distance / Speed;
        }
    }
}
