namespace AfficheurLcd.tests
{
	public class AfficheurLcdTests
	{
		[Theory]
		[InlineData(0, " _ " + "\n" + "| |" + "\n" + "|_|")]
		[InlineData(1, "   " + "\n" + "  |" + "\n" + "  |")]
		[InlineData(2, " _ " + "\n" + " _|" + "\n" + "|_ ")]
		[InlineData(3, " _ " + "\n" + " _|" + "\n" + " _|")]
		[InlineData(4, "   " + "\n" + "|_|" + "\n" + "  |")]
		[InlineData(5, " _ " + "\n" + "|_ " + "\n" + " _|")]
		[InlineData(6, " _ " + "\n" + "|_ " + "\n" + "|_|")]
		[InlineData(7, " _ " + "\n" + "  |" + "\n" + "  |")]
		[InlineData(8, " _ " + "\n" + "|_|" + "\n" + "|_|")]
		[InlineData(9, " _ " + "\n" + "|_|" + "\n" + " _|")]
		public void AfficherNombre(int nombre, string expected)
		{
			expected = expected.Replace("\n", Environment.NewLine);
			string result = nombre switch
			{
				0 => Nombres.Zero,
				1 => Nombres.Un,
				2 => Nombres.Deux,
				3 => Nombres.Trois,
				4 => Nombres.Quatre,
				5 => Nombres.Cinq,
				6 => Nombres.Six,
				7 => Nombres.Sept,
				8 => Nombres.Huit,
				9 => Nombres.Neuf,
			};

			Assert.Equal(expected, result);
		}

		[Fact]
		public void AsciiToLcd()
		{
			var convertisseur = new ConvertisseurLcd();
			var nombreAttendu = "   " + Environment.NewLine +
			                          "  |" + Environment.NewLine +
			                          "  |";

			var resultat = convertisseur.ConvertirEnLcd(1);

			Assert.Equal(nombreAttendu, resultat);
		}
		[Fact]
		public void AsciiToLcd2()
		{
			var convertisseur = new ConvertisseurLcd();
			var nombreAttendu = " _ " + Environment.NewLine +
			                          " _|" + Environment.NewLine +
			                          "|_ ";

			var resultat = convertisseur.ConvertirEnLcd(2);

			Assert.Equal(nombreAttendu, resultat);
		}
		[Fact]
		public void AsciiToLcd3()
		{
			var convertisseur = new ConvertisseurLcd();
			var nombreAttendu = " _ " + Environment.NewLine +
								      " _|" + Environment.NewLine +
								      " _|";

			var resultat = convertisseur.ConvertirEnLcd(3);

			Assert.Equal(nombreAttendu, resultat);
		}

		[Fact]
		public void AsciiToLcd4()
		{
			var convertisseur = new ConvertisseurLcd();
			var nombreAttendu = "   " + Environment.NewLine +
								      "|_|" + Environment.NewLine +
								      "  |";

			var resultat = convertisseur.ConvertirEnLcd(4);

			Assert.Equal(nombreAttendu, resultat);
		}

		[Fact]
		public void AsciiToLcd5()
		{
			var convertisseur = new ConvertisseurLcd();
			var nombreAttendu = " _ " + Environment.NewLine +
								      "|_ " + Environment.NewLine +
								      " _|";

			var resultat = convertisseur.ConvertirEnLcd(5);

			Assert.Equal(nombreAttendu, resultat);
		}

		[Fact]
		public void AsciiToLcd6()
		{
			var convertisseur = new ConvertisseurLcd();
			var nombreAttendu = " _ " + Environment.NewLine +
								      "|_ " + Environment.NewLine +
								      "|_|";

			var resultat = convertisseur.ConvertirEnLcd(6);

			Assert.Equal(nombreAttendu, resultat);
		}

		[Fact]
		public void AsciiToLcd7()
		{
			var convertisseur = new ConvertisseurLcd();
			var nombreAttendu = " _ " + Environment.NewLine +
								      "  |" + Environment.NewLine +
								      "  |";

			var resultat = convertisseur.ConvertirEnLcd(7);

			Assert.Equal(nombreAttendu, resultat);
		}

		[Fact]
		public void AsciiToLcd8()
		{
			var convertisseur = new ConvertisseurLcd();
			var nombreAttendu = " _ " + Environment.NewLine +
								      "|_|" + Environment.NewLine +
								      "|_|";

			var resultat = convertisseur.ConvertirEnLcd(8);

			Assert.Equal(nombreAttendu, resultat);
		}

		[Fact]
		public void AsciiToLcd9()
		{
			var convertisseur = new ConvertisseurLcd();
			var nombreAttendu = " _ " + Environment.NewLine +
								      "|_|" + Environment.NewLine +
								      " _|";

			var resultat = convertisseur.ConvertirEnLcd(9);

			Assert.Equal(nombreAttendu, resultat);
		}
		public void AsciiToLcd0()
		{
			var convertisseur = new ConvertisseurLcd();
			var nombreAttendu = " _ " + Environment.NewLine +
			                          "| |" + Environment.NewLine +
			                          "|_|";

			var resultat = convertisseur.ConvertirEnLcd(0);

			Assert.Equal(nombreAttendu, resultat);
		}
	}
}