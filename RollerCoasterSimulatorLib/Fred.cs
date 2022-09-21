﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using RollerCoasterSimulatorLib.Cart;
using RollerCoasterSimulatorLib.Map;

namespace RollerCoasterSimulatorLib
{
    /// <summary>
    /// Fred is the class that runs everything, therefore Fred is our main that calls the methods of other classes
    /// to advance rockets, when a downtime occurs, and so on.
    /// </summary>
    public class Fred
    {
        Track mainTrack;
        RocketManager rocketManager;
        public Fred()
        {
           mainTrack = new Track();
           rocketManager = new RocketManager();
        }
    }
}
