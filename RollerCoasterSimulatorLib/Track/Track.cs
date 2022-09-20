using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoasterSimulatorLib.Track
{
    public class Track
    {
        public Track()
        {
            Intialize();
        }

        
        /// <summary>
        /// Intializes by adding all the zone names of space mountain to the zones class.
        /// </summary>
        private void Intialize()
        {
            Zones.Add("Zone 1", 5, 8);
            Zones.Add("Zone 2", 5, 8);
            Zones.Add("Zone 3", 5, 8);
            Zones.Add("Zone 4", 5, 8);
            Zones.Add("Zone 5", 5, 8);
            Zones.Add("Zone 6", 5, 8);
            Zones.Add("Zone 7", 5, 8);
            Zones.Add("Zone 8", 5, 8);
            Zones.Add("Zone 9", 5, 8);
            Zones.Add("Zone 10", 5, 8);
            Zones.Add("Zone 11", 5, 8);
            Zones.Add("Zone 12", 5, 8);
            Zones.Add("Zone 13", 5, 8);
            Zones.Add("Zone 14", 5, 8);
            Zones.Add("Zone 15", 5, 8);
            Zones.Add("Hold 2", 5, 8);
            Zones.Add("Hold 1", 5, 8);
            Zones.Add("Unload", 5, 8);
            Zones.Add("Load", 5, 8);
            Zones.Add("Ready", 5, 8);
            Zones.Add("Dispatch", 5, 8);
        }

        /// <summary>
        /// Get's all the zones out of the list
        /// </summary>
        /// <returns>a list of all the zones</returns>
        public List<Zone> GetAll()
        {
            return Zones.zones;
        }

        /// <summary>
        /// Get's Zone by Index
        /// </summary>
        /// <param name="i"></param>
        /// <returns>The zone retrieved</returns>
        public Zone GetZone(int i)
        {
            return Zones.GetZone(i);
        }

        /// <summary>
        /// Gets zone by zone name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Zone retrieved</returns>
        public Zone GetZone(string name)
        {
            return Zones.GetZone(name);
        }
    }
}
