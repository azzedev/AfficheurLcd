namespace AfficheurLcd.tests
{
	public class AfficheurLcdTests
	{
		[Fact]
		public void AfficherNombre1()
		{
			var expected = "   " + Environment.NewLine +
			                     "  |" + Environment.NewLine +
			                     "  |";

			var result = Nombres.Un;

			Assert.Equal(expected, result);
		}

		[Fact]
		public void AfficherNombre2()
		{
			var expected = " _ " + Environment.NewLine + 
			                     " _|" + Environment.NewLine +
			                     "|_ ";
			var result = Nombres.Deux;

			Assert.Equal(expected, result);
		}
		[Fact]
		public void AfficherNombre3()
		{
			var expected = " _ " + Environment.NewLine +
			                     " _|" + Environment.NewLine +
								 " _|";
			var result = Nombres.Trois;

			Assert.Equal(expected, result);
		}

		[Fact]
		public void AfficherNombre4()
		{
			var expected = "   " + Environment.NewLine +
						         "|_|" + Environment.NewLine +
						         "  |";
			var result = Nombres.Quatre;

			Assert.Equal(expected, result);
		}

		[Fact]
		public void AfficherNombre5()
		{
			var expected = " _ " + Environment.NewLine +
			                     "|_ " + Environment.NewLine +
			                     " _|";
			var result = Nombres.Cinq;

			Assert.Equal(expected, result);
		}

		[Fact]
		public void AfficherNombre6()
		{
			var expected = " _ " + Environment.NewLine +
			                     "|_ " + Environment.NewLine +
						         "|_|";
			var result = Nombres.Six;

			Assert.Equal(expected, result);
		}

		[Fact]
		public void AfficherNombre7()
		{
			var expected = " _ " + Environment.NewLine +
						         "  |" + Environment.NewLine +
						         "  |";
			var result = Nombres.Sept;

			Assert.Equal(expected, result);
		}

		[Fact]
		public void AfficherNombre8()
		{
			var expected = " _ " + Environment.NewLine +
						         "|_|" + Environment.NewLine +
						         "|_|";
			var result = Nombres.Huit;

			Assert.Equal(expected, result);
		}

		[Fact]
		public void AfficherNombre9()
		{
			var expected = " _ " + Environment.NewLine +
						         "|_|" + Environment.NewLine +
						         " _|";
			var result = Nombres.Neuf;

			Assert.Equal(expected, result);
		}

		[Fact]
		public void AfficherNombre0()
		{
			var expected = " _ " + Environment.NewLine +
						         "| |" + Environment.NewLine +
						         "|_|";
			var result = Nombres.Zero;

			Assert.Equal(expected, result);
		}
	}
}