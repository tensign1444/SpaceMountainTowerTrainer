using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoasterSimulatorLib.Map
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
            Zones.Add("Zone 1", 5, 5);
            Zones.Add("Zone 2", 4, 4);
            Zones.Add("Zone 3", 5, 5);
            Zones.Add("Zone 4", 8, 8);
            Zones.Add("Zone 5", 5, 5);
            Zones.Add("Zone 6", 3, 3);
            Zones.Add("Zone 7", 5, 5);
            Zones.Add("Zone 8", 5, 7);
            Zones.Add("Zone 9", 5, 6);
            Zones.Add("Zone 10", 3, 6);
            Zones.Add("Zone 11", 5, 5);
            Zones.Add("Zone 12", 5, 5);
            Zones.Add("Zone 13", 4, 5);
            Zones.Add("Zone 14", 4, 6);
            Zones.Add("Zone 15", 5, 8);
            Zones.Add("Hold 2");
            Zones.Add("Hold 1");
            Zones.Add("Unload");
            Zones.Add("Load");
            Zones.Add("Ready");
            Zones.Add("Dispatch");


            //______Inserting next zones______

            List<Zone> zones = GetAll();
            for(int i = 0; i < zones.Count; i++)
            {
                if (i == zones.Count - 1)
                    zones[i].nextZone = zones[0];
                else
                    zones[i].nextZone = zones[i + 1];
            }

            Zones.Add("Storage");
            GetZone(zones.Count - 1).nextZone = GetZone("Hold 1");
            
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
