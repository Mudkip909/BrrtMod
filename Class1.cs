using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace ClassLibarary1    
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class BrrtMod : MonoBehaviour
    {
        public void Update()
        {
            double vesselSpeed = FlightGlobals.ActiveVessel.srfSpeed;
            if (vesselSpeed > 0)
            {
                vesselSpeed /= 10;
                var vessel = FlightGlobals.ActiveVessel;
                var dvThing = vessel.transform.up;
                dvThing *= (float)vesselSpeed;
                vessel.ChangeWorldVelocity(dvThing);
            }
        }
    }
}
