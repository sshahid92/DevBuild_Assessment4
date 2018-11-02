using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4_AbstractDroneClass
{
    public abstract class Drone
    {
        //1a. private int variable are created in the background
        public int TotalFlyTime { get; set; }
        public int TotalDistance { get; set; }
        
        //1b. constructor with overloads
        public Drone()
        {

        }
        public Drone(int totalFlyTime, int totalDistance)
        {
            TotalFlyTime = totalFlyTime;
            TotalDistance = totalDistance;
        }
        
        //1c. Abstract method named flightspeed
        public virtual double FlightSpeed()
        {
            double speed = (double)TotalDistance / TotalFlyTime;
            return speed;
        }
    }

    
}
