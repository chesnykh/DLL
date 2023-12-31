﻿// Garage.cs
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace ChesnykhDM34IS.Library
{
	public class Garage
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public List<Car> Cars { get; set; }

		public Garage()
		{
			Cars = new List<Car>();
		}

		public void ShowAll()
		{
			Console.WriteLine($"Garage: {Name}, Address: {Address}");
			foreach (Car car in Cars)
			{
				car.Show();
			}
		}
	}
}
