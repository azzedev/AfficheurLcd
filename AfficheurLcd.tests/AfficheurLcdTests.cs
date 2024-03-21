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
	}
}