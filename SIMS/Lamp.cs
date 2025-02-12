using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS
{
    public class Lamp : Devices
    {
        public override string Function()
        {
            if (Description == true)
            {
                return ($"{Name} is on due to the natural circumstances.");
            }
            else
            {
                return ($"{Name} turned off due to the abundance of light. ");
            }
        }
    }
}
