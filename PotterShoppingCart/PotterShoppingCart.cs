using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
	public class PotterShoppingCart
	{
		private Dictionary<string, int> m_Potters = new Dictionary<string, int>
		{
			["哈利波特1"] = 0,
			["哈利波特2"] = 0,
			["哈利波特3"] = 0,
			["哈利波特4"] = 0,
			["哈利波特5"] = 0,
		};

		public void BuyFirstEpisode(int quantity)
		{
			this.m_Potters["哈利波特1"] += quantity;
		}

		public void BuySecondEpisode(int quantity)
		{
			this.m_Potters["哈利波特2"] += quantity;
		}


		public void BuyThirdEpisode(int quantity)
		{
			this.m_Potters["哈利波特3"] += quantity;
		}

		public void BuyForthEpisode(int quantity)
		{
			this.m_Potters["哈利波特4"] += quantity;
		}

		public void BuyFifthEpisode(int quantity)
		{
			this.m_Potters["哈利波特5"] += quantity;
		}

		public decimal Payables()
		{
			var discount = 1M;
			var books = this.m_Potters.Where(p => p.Value > 0).Count();

			if (books >= 4)
				discount = 0.8M;
			if (books == 3)
				discount = 0.9M;
			else if (books == 2)
				discount = 0.95M;

			return this.m_Potters.Values.Sum() * 100 * discount;
		}
	}
}
