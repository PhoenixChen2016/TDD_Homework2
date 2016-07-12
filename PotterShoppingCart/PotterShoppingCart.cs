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
		private static decimal[] _Discounts = { 1M, 1M, 0.95M, 0.9M, 0.8M, 0.75M };

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

		public void BuyPotter(PotterBook potter, int quantity)
		{
		}

		public decimal Payables()
		{
			var totalAmount = 0M;

			CalculatePayables(this.m_Potters.Values.ToArray(), ref totalAmount);

			return totalAmount;
		}

		private static void CalculatePayables(int[] potters, ref decimal pay)
		{
			var books = potters.Count(v => v > 0);
			var discount = _Discounts[books];

			var set = potters.Where(v => v > 0).Min();

			pay += set * books * 100 * discount;

			var newPotters = potters.Select(v => v == 0 ? v : v - set).ToArray();

			if (newPotters.Sum() > 0)
				CalculatePayables(newPotters, ref pay);
		}
	}
}
