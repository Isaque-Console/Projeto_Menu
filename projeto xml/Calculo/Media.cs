using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo
{
	class Media
    {
		public static void Aluno(int QtdNotas)
		{
			List<double> notas = new List<double>();
			double ans = 0;
			for (int i = 1; i <= QtdNotas; i++)
			{
				Console.WriteLine("Digite a " + i + "º " + "nota: ");
				notas.Add(double.Parse(Console.ReadLine()));
				ans += notas[i - 1] / QtdNotas;
			}
			Console.WriteLine("A média desse aluno é: " + ans + "\n");
		}
	}
}
