using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfficheurLcd
{
	public static class Exeptions
	{
		public static void ThrowIfNegative(int number, string message = null)
		{
			if (number < 0)
			{
				throw new ArgumentException("Veuillez entrer un nombre positif.");
			}
		}
	}
}
