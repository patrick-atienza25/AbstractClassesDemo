﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk = true;
        public Car()
        {
           
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving with abstract");
        }
    }
}
