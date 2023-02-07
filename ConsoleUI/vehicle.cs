using System;
namespace ConsoleUI
{
	internal abstract class vehicle
	{
		public string Year { get; set; } = "default";
		public string Make { get; set; } = "default";
		public string Model { get; set; } = "default";

		public abstract void DriveAbstract();

		public virtual void DriveVirtual()
		{
			Console.WriteLine("default virtual drive");
		}
		
	}
}

