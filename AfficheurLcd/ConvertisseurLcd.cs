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
			if (nombre == 1)
			{
				return "   " + Environment.NewLine +
					   "  |" + Environment.NewLine +
					   "  |";
			}
			else
			{
				return "";
			}
		}
	}
}
