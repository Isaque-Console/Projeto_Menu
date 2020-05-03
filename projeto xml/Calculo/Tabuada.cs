using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo
{
    class Tabuada
    {
		public static void Numero(int x)
		{
			for (int i = 1; i < 11; i++)
			{
				Console.WriteLine(x + " X " + i + " = " + (i * x) + "\n");
			}
		}
	}
}
