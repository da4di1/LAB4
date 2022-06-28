using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerCarriers
{
    public interface ITransport
    {
        string Brand { get; set; }
        float Speed { get; set; }  // in km/h

        float CalculateDrivingTime(float distance);  //takes kms, returns hours
    }
}
