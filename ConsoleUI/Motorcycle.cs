using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart = true;
        public Motorcycle()
        {
            
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("Drive Abstract");
        }
    }
}
