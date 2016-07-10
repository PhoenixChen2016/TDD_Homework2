using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
	[TestClass]
	public class PotterShoppingCartTests
	{
		[TestMethod]
		public void PotterShopping_只買第一集價格是100元()
		{
			// arrange
			var sut = new PotterShoppingCart();

			sut.BuyFirstEpisode(1);

			// act
			var actual = sut.Payables();

			// assert
			var expected = 100;

			Assert.AreEqual(expected, actual);
		}
	}
}
