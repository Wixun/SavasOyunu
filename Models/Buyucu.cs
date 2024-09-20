using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasOyunu.Models
{
	public class Buyucu
	{
		public string OyuncuIsmi { get; set; }
		public string Brans { get; set; }
		public string Irk { get; set; }
		public string Silah { get; set; }
		public int SaldiriGucu { get; set; }

		public void SaldiriGucuHesapla()
		{
			switch (Brans)
			{
				case "Karabüyü":
					SaldiriGucu += 50;
					break;
				case "BüyülüSilah":
					SaldiriGucu += 65;
					break;
				case "Iyilestirmeci":
					SaldiriGucu += 35;
					break;
				case "EjderhaGucu":
					SaldiriGucu += 45;
					break;
				default:
					SaldiriGucu += 30;
					break;
			}

			switch (Silah)
			{
				case "AntikaÇan":
					SaldiriGucu += 15;
					break;
				case "DolunayKilici":
					SaldiriGucu += 25;
					break;
				default:
					SaldiriGucu += 5;
					break;
			}

			switch (Irk)
			{
				case "Şaman":
					SaldiriGucu += 3;
					break;
				case "Sura":
					SaldiriGucu += 5;
					break;
			}
		}
	}
}