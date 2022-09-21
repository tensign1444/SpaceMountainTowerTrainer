using RollerCoasterSimulatorLib.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoasterSimulatorLib.Cart
{
    /// <summary>
    /// RocketManager so we can manage all our rockets.
    /// </summary>
    public class RocketManager
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public RocketManager()
        {
            CreateRockets();
            AddRocketsOnTrack();
        }

        /// <summary>
        /// Adds rockets onto track on power on
        /// </summary>
        private void AddRocketsOnTrack()
        {
           for(int i = 0; i < 6; i++)
           {
                Zone zone = Zones.zones[(Zones.zones.Count - i) - 2];
                zone.isOccupied = true;
                Rockets.GetRocket(i).OccupiedZone = zone;
           }
           
        }

        /// <summary>
        /// creates rockets upon power on
        /// </summary>
        private void CreateRockets()
        {
            for (int i = 1; i <= 11; i++)
            {
                Rockets.Add(i, Zones.GetZone("Storage"));
            }
        }

        /// <summary>
        /// Advances the rocket from the rocket manager
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool AdvanceRocket(int i)
        {
            return Rockets.GetRocket(i).Advance();
        }

        /// <summary>
        /// Get's all the rockets
        /// </summary>
        /// <returns></returns>
        public List<Rocket> GetAll()
        {
            return Rockets.rockets;
        }
    }
    

    /// <summary>
    /// Class to hold all the rockets
    /// </summary>
    public static class Rockets
    {
        //List of all the zones
        public static List<Rocket> rockets = new List<Rocket>();


        /// <summary>
        /// Adds a rocket to a list of rockets to keep track of all rockets
        /// </summary>
        /// <param number="number"> number of rocket</param>
        /// <param OccupiedZone="OccupiedZone"> current occupied zone</param>
        public static void Add(int number, Zone OccupiedZone)
        {
            rockets.Add(new Rocket(number, OccupiedZone));
        }

        /// <summary>
        /// Gets rocket by the number of the rocket
        /// </summary>
        /// <param number="number">number of rocket</param>
        /// <returns>the rocket</returns>
        public static Rocket GetRocket(int number)
        {
            return rockets[number];
        }

    }
}
