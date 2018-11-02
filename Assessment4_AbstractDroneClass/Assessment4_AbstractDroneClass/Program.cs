using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4_AbstractDroneClass
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadrotorDrone drone = new QuadrotorDrone(10, 20);

            Console.WriteLine(drone.FlightSpeed()); 
            Console.ReadLine();
            //3. Explain how you used teh SOLID Principles
            /*I applied SOLID by having a single class being responsible for calculating the drone speed.
             *Then by creating an abstract class i was able to extend the properties of the Flight speed method
             * to make the Quadroto Drone have a different level of speed distance and fly time. this added an
             element of polymorphism that satisfies liscovs principle. Also by doing this the base class 
             does not depend on the subclass
             
             side not. the instructions called for private integers in the base class and by using the property shorthand
             i feel i ht that requirement because it creates the private variable in the background*/
        }
    }
}
