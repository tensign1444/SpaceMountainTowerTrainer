using RollerCoasterSimulatorLib.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoasterSimulatorLib.Cart
{
    public class Rocket
    {


        /// <summary>
        /// Constructor to create a zone
        /// </summary>
        /// <param name="name"></param>
        /// <param name="minTime"></param>
        /// <param name="maxTime"></param>
        public Rocket(int Number, Zone OccupiedZone = null, double weight = 3880.00)
        {
            this.Number = Number;
            this.Weight = weight;
            this.OccupiedZone = OccupiedZone;
        }

        public bool Advance()
        {
            if (!this.OccupiedZone.nextZone.isOccupied)
            {
                this.OccupiedZone.isOccupied = false;
                this.OccupiedZone = OccupiedZone.nextZone;
                this.OccupiedZone.isOccupied = true;
                return true;
            }
            else
                return false;
            
        }

        /// <summary>
        /// Name of the zone
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Min time for a cart to occupy a zone
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Max time for a cart to occupy a zone
        /// </summary>
        public Zone OccupiedZone { get; set; }
    }
}
