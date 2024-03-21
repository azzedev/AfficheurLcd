using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace AfficheurLcd
{
	public class ConvertisseurLcd
	{
		public string ConvertirEnLcd(int nombre)
		{
			if (nombre < 0)
			{
				Exeptions.ThrowIfNegative(nombre);
			}

			if (nombre >= 0 && nombre <= 9)
			{
				return nombre switch
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
			}

			else if (nombre == 10)
			{
				var un = Nombres.Un.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
				var zero = Nombres.Zero.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

				var ligne1 = un[0] + " " + zero[0];
				var ligne2 = un[1] + " " + zero[1];
				var ligne3 = un[2] + " " + zero[2];

				return $"{ligne1}{Environment.NewLine}{ligne2}{Environment.NewLine}{ligne3}";
			}

			return "";
		}

	}
}
