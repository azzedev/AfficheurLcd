using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

	}
}
