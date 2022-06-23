using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassengerCarriers;
using Animals;

namespace Lab4NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger = new Passenger();
            ITransport transport = null;
            IAnimal animal;

            float distanceToTravel = 500; // in kms
            float typeOfWay = 0; // 0 - road, 1 - steppe, 2 - desert

            if(typeOfWay == 0)
            {
                if (distanceToTravel > 0 && distanceToTravel <= 250)
                    transport = new Bike("Capybara cycle", 28);
                else if (distanceToTravel > 0 && distanceToTravel > 250)
                    transport = new Car("Tesla X", 200, 0);
                else
                {
                    Console.WriteLine("Wrong input for way type");
                }
            }
            else if(typeOfWay == 1)
            {
                animal = new Horse("Juan", "Arabic Horse", 15);
                transport = new AnimalToTransportAdapter(animal);
            }
            else if(typeOfWay == 2)
            {
                animal = new Camel("Ciga", "Kharai Camel", 25);
                transport = new AnimalToTransportAdapter(animal);
            }
            else
            {
                Console.WriteLine("Wrong input for way type");
            }

            if(transport != null)
            {
                string travelReport = passenger.Travel(transport, distanceToTravel);
                Console.WriteLine(travelReport);
            }
        }
    }
}
