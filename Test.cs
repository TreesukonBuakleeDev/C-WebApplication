using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarchProject.Controllers
{
    public class Test
    {
        public float StarchEfficiency(float input1,float input2)
        {
            return input1 / input2 * 100;
        }

        public float PulpExtractEfficiency(float input1, float input2)
        {
            return (1 - (input1 / input2)) * 100;
        }
        public float UnitCapacity(float input1, float input2)
        {
            return input1 / input2 * 100;
        }
    }
}