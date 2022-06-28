using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Breed { get; set; }
        float Age { get; set; }
        float Speed { get; set; }  // in km/h
        float maxTimeWithoutRest { get; set; }  //in hours
        float TimeToRestoreStamina { get; set; }  //in hours

        float CalculateMovingTime(float distance);  //takes kms, returns hours
    }
}
