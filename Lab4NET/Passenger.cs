using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassengerCarriers;

namespace Lab4NET
{
    public class Passenger
    {
        public string Travel(ITransport transport, float distance)
        {
            float time = transport.CalculateDrivingTime(distance);

            return $"You will travel {distance} km(s) in {time} hour(s) with {transport.Brand}";
        } 
    }
}
