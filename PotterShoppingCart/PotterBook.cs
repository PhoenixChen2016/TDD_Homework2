using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
	public sealed class PotterBook
	{
		public static PotterBook FirstEpisode { get; } = new PotterBook { Name = "哈利波特1" };
		public static PotterBook SecondEpisode { get; } = new PotterBook { Name = "哈利波特2" };
		public static PotterBook ThirdEpisode { get; } = new PotterBook { Name = "哈利波特3" };
		public static PotterBook ForthEpisode { get; } = new PotterBook { Name = "哈利波特4" };
		public static PotterBook FifthEpisode { get; } = new PotterBook { Name = "哈利波特5" };

		public string Name { get; private set; }

		private PotterBook()
		{

		}


	}
}
