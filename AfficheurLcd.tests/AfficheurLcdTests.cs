namespace AfficheurLcd.tests
{
	public class AfficheurLcdTests
	{
		[Fact]
		public void AfficherNombre1()
		{
			var expected = $"   {Environment.NewLine}  |{Environment.NewLine}  |";

			var result = Nombres.Un;

			Assert.Equal(expected, result);
		}
	}
}