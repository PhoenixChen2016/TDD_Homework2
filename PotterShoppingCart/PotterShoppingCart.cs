using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
	public class PotterShoppingCart
	{
		private Dictionary<PotterBook, int> m_Potters = new Dictionary<PotterBook, int>
		{
			[PotterBook.FirstEpisode] = 0,
			[PotterBook.SecondEpisode] = 0,
			[PotterBook.ThirdEpisode] = 0,
			[PotterBook.ForthEpisode] = 0,
			[PotterBook.FifthEpisode] = 0,
		};
		private static Dictionary<int, decimal> _Discounts = new Dictionary<int, decimal>
		{
			[1] = 1M,
			[2] = 0.95M,
			[3] = 0.9M,
			[4] = 0.8M,
			[5] = 0.75M
		};

		public void BuyPotter(PotterBook potter, int quantity)
		{
			this.m_Potters[potter] += quantity;
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
