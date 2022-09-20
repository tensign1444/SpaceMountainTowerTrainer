using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoasterSimulatorLib.Track
{
    /// <summary>
    /// A class which holds all the zones in memory
    /// </summary>
    public static class Zones
    {
        //List of all the zones
        public static List<Zone> zones = new List<Zone>();

        /// <summary>
        /// Adds a zone to a list of zones to keep track of all zones
        /// </summary>
        /// <param name="name"> name of zone</param>
        /// <param name="minTime"> min time in zone</param>
        /// <param name="maxTime"> max time in zone</param>
        public static void Add(string name, int minTime, int maxTime)
        {
            zones.Add(new Zone(name, minTime, maxTime));
        }

        /// <summary>
        /// Gets zone by the name of the zone
        /// </summary>
        /// <param name="name">name of zone</param>
        /// <returns>the name of the zone or throws an exception if it isn't found</returns>
        /// <exception cref="Exception"></exception>
        public static Zone GetZone(string name)
        {
            for(int i = 0; i < zones.Count; i++)
            {
                if(zones[i].name == name)
                    return zones[i];
            }

            throw new Exception("No Zone Found");
        }

        /// <summary>
        /// Gets a zone by the index
        /// </summary>
        /// <param name="idx">number of index you want</param>
        /// <returns>the name of the zone</returns>
        public static Zone GetZone(int idx)
        {
            return zones[idx];
        }
    }

    /// <summary>
    /// Custom structure for a zone within the track
    /// </summary>
    public struct Zone
    {

        /// <summary>
        /// Constructor to create a zone
        /// </summary>
        /// <param name="name"></param>
        /// <param name="minTime"></param>
        /// <param name="maxTime"></param>
        public Zone(string name, int minTime, int maxTime)
        {
            this.name = name;
            this.minTime = minTime;
            this.maxTime = maxTime;
        }

        /// <summary>
        /// Name of the zone
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Min time for a cart to occupy a zone
        /// </summary>
        public int minTime { get; set; }

        /// <summary>
        /// Max time for a cart to occupy a zone
        /// </summary>
        public int maxTime { get; set; }
    }



}
