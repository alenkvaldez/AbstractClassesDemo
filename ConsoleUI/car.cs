using System;
namespace ConsoleUI
{
	internal class car : vehicle
	{
		public bool HasTrunk { get; set; }

		public override void DriveAbstract()
		{
			Console.WriteLine("car is driving");
		}
	}
}

