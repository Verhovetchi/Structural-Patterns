using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.WashingMachine
{
     class Thermo
     {
          public int GetTemperature()
          {
               return 50;
          }

          public void WarmUp(int degrees)
          {
               Console.WriteLine("Warm for {0} degrees", degrees);
          }
     }
}
