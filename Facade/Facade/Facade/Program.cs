﻿using Facade.WashingMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
     class Program
     {
          static void Main(string[] args)
          {
               var water = new WaterManagingSubsystem();
               var thermo = new Thermo();
               var engine = new Engine();
               var dryer = new Dryer();

               var washingMachine = new WashingMachine.WashingMachine(dryer, engine, thermo, water);

               Console.WriteLine();
               Console.WriteLine("\t\t\t\t\t\tForm");
               washingMachine.WashForm();

               Console.WriteLine();
               Console.WriteLine("\t\t\t\t\t\tSneakers");
               washingMachine.WashSneakers();

               int temp = washingMachine.GetTemperature();

               Console.ReadKey();
          }
     }
}
