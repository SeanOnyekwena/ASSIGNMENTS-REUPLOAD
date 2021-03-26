using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempconv3
{
    class Degrees
    {
        public double CTF(double val)
        {
            return (val * 9) / 5 + 32;
        }
        public double FTC(double val)
        {
            return (val - 32) * 5 / 9;
        }
    }
}
