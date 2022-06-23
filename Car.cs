using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    public class Car : ITransport
    {
        public string Brand { get; set; }
        public float Speed { get; set; }
        public float TankCapacity { get; set; }


        public Car(string brand, float speed, float tankCapacity)
        {
            Brand = brand;
            Speed = speed;
            TankCapacity = tankCapacity;
        }

        public float CalculateDrivingTime(float distance)
        {
            return distance / Speed;
        }
    }
}
