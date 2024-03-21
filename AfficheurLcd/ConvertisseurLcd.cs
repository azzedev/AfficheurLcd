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
			return nombre switch
			{
				1 => Nombres.Un,
				2 => Nombres.Deux,
			};
		}
	}
}
