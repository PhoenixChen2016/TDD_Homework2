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

			sut.BuyPotter(PotterBook.FirstEpisode, 1);

			// act
			var actual = sut.Payables();

			// assert
			var expected = 100M;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PotterShopping_買第一集一本_買第二集一本_價格應該打95折為190元()
		{
			// arrange
			var sut = new PotterShoppingCart();

			sut.BuyPotter(PotterBook.FirstEpisode, 1);
			sut.BuyPotter(PotterBook.SecondEpisode, 1);

			// act
			var actual = sut.Payables();

			// assert
			var expected = 190M;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PotterShopping_一二三集各買了一本_價格應該打9折為270元()
		{
			// arrange
			var sut = new PotterShoppingCart();

			sut.BuyPotter(PotterBook.FirstEpisode, 1);
			sut.BuyPotter(PotterBook.SecondEpisode, 1);
			sut.BuyPotter(PotterBook.ThirdEpisode, 1);

			// act
			var actual = sut.Payables();

			// assert
			var expected = 270M;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PotterShopping_一二三四集各買了一本_價格應該打8折為320元()
		{
			// arrange
			var sut = new PotterShoppingCart();

			sut.BuyPotter(PotterBook.FirstEpisode, 1);
			sut.BuyPotter(PotterBook.SecondEpisode, 1);
			sut.BuyPotter(PotterBook.ThirdEpisode, 1);
			sut.BuyPotter(PotterBook.ForthEpisode, 1);

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

			sut.BuyPotter(PotterBook.FirstEpisode, 1);
			sut.BuyPotter(PotterBook.SecondEpisode, 1);
			sut.BuyPotter(PotterBook.ThirdEpisode, 1);
			sut.BuyPotter(PotterBook.ForthEpisode, 1);
			sut.BuyPotter(PotterBook.FifthEpisode, 1);

			// act
			var actual = sut.Payables();

			// assert
			var expected = 375M;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PotterShopping_一二集各買了一本_第三集買了兩本_價格應為370元()
		{
			// arrange
			var sut = new PotterShoppingCart();

			sut.BuyPotter(PotterBook.FirstEpisode, 1);
			sut.BuyPotter(PotterBook.SecondEpisode, 1);
			sut.BuyPotter(PotterBook.ThirdEpisode, 2);

			// act
			var actual = sut.Payables();

			// assert
			var expected = 370M;

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PotterShopping_第一集買了一本_第二三集各買了兩本_價格應為460元()
		{
			// arrange
			var sut = new PotterShoppingCart();

			sut.BuyPotter(PotterBook.FirstEpisode, 1);
			sut.BuyPotter(PotterBook.SecondEpisode, 2);
			sut.BuyPotter(PotterBook.ThirdEpisode, 2);

			// act
			var actual = sut.Payables();

			// assert
			var expected = 460M;

			Assert.AreEqual(expected, actual);
		}
	}
}
