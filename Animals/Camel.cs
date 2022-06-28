using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Camel : IAnimal
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public float Age { get; set; }
        public float Speed { get; set; } = 65;
        public float maxTimeWithoutRest { get; set; } = 8;
        public float TimeToRestoreStamina { get; set; } = 0.5f;


        public Camel(string name, string breed, float age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }

        public float CalculateMovingTime(float distance)
        {
            float timeToTravel = distance / Speed;

            if (timeToTravel > maxTimeWithoutRest)
                return timeToTravel + (timeToTravel % maxTimeWithoutRest) * TimeToRestoreStamina;
            else
                return timeToTravel;
        }
    }
}
