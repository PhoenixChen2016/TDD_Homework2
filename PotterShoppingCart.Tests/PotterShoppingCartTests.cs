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

		[TestMethod]
		public void PotterShopping_買第一集一本_買第二集一本_價格應該打95折為190元()
		{
			// arrange
			var sut = new PotterShoppingCart();

			sut.BuyFirstEpisode(1);
			sut.BuySecondEpisode(1);

			// act
			var actual = sut.Payables();

			// assert
			var expected = 190;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PotterShopping_一二三集各買了一本_價格應該打9折為270元()
		{
			// arrange
			var sut = new PotterShoppingCart();

			sut.BuyFirstEpisode(1);
			sut.BuySecondEpisode(1);
			sut.BuyThirdEpisode(1);

			// act
			var actual = sut.Payables();

			// assert
			var expected = 270;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PotterShopping_一二三四集各買了一本_價格應該打8折為320元()
		{
			// arrange
			var sut = new PotterShoppingCart();

			sut.BuyFirstEpisode(1);
			sut.BuySecondEpisode(1);
			sut.BuyThirdEpisode(1);
			sut.BuyForthEpisode(1);

			// act
			var actual = sut.Payables();

			// assert
			var expected = 320;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PotterShopping_一次買了整套_一二三四五集各買了一本_價格應該打75折為375元()
		{
			// arrange
			var sut = new PotterShoppingCart();

			sut.BuyFirstEpisode(1);
			sut.BuySecondEpisode(1);
			sut.BuyThirdEpisode(1);
			sut.BuyForthEpisode(1);
			sut.BuyFifthEpisode(1);

			// act
			var actual = sut.Payables();

			// assert
			var expected = 375;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PotterShopping_一二集各買了一本_第三集買了兩本_價格應為370元()
		{
			// arrange
			var sut = new PotterShoppingCart();

			sut.BuyFirstEpisode(1);
			sut.BuySecondEpisode(1);
			sut.BuyThirdEpisode(2);

			// act
			var actual = sut.Payables();

			// assert
			var expected = 370;

			Assert.AreEqual(expected, actual);
		}
	}
}
