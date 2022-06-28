using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals;

namespace PassengerCarriers
{
    public class AnimalToTransportAdapter : ITransport
    {
        private IAnimal animal;
        public string Brand { get; set; }
        public float Speed { get; set; }

        public AnimalToTransportAdapter(IAnimal animal)
        {
            this.animal = animal;
            Brand = animal.Breed;
            Speed = animal.Speed;
        }

        public float CalculateDrivingTime(float distance)
        {
            return animal.CalculateMovingTime(distance);
        }
    }
}
