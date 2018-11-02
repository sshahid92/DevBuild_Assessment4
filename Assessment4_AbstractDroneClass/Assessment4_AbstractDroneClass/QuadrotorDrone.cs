using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4_AbstractDroneClass
{
    //2a. class that extends drone
    class QuadrotorDrone : Drone
    {
        public QuadrotorDrone(int totalFlyTime, int totalDistance) : base(totalFlyTime, totalDistance)
        {
        }

        //2b. implements the flight speed method
        public override double FlightSpeed()
        {
            //2bi. Changing the variables to get a different result
            TotalDistance += 100;
            TotalFlyTime += 34;
            return base.FlightSpeed();
        }
    }
}
