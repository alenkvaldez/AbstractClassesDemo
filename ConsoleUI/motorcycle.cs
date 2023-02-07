using System;
namespace ConsoleUI
{
	internal class motorcycle : vehicle
	{
        public bool HasSide { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("cycle is cycling");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("moto virtual drive");
        }
    }
}

