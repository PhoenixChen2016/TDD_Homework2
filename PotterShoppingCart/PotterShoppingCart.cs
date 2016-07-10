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
			
		}

		public object Payables()
		{
			throw new NotImplementedException();
		}
	}
}
