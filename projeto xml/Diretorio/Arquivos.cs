using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Diretorio
{
    class Arquivos
    {
		private static string CaminhoArquivo()
		{
			return ConfigurationManager.AppSettings["CaminhoArquivos"];
		}
		public static void Ler(int numeroarquivo)
		{
			string caminho = CaminhoArquivo() + "arq" + numeroarquivo + ".txt";
			if (File.Exists(caminho))
			{
				using (StreamReader arquivo = File.OpenText(caminho))
				{
					string linha;
					Console.WriteLine("===================================" + caminho + " ===================================");

					while ((linha = arquivo.ReadLine()) != null)
					{
						Console.WriteLine(linha);
					}
				}
			}
			string caminho2 = CaminhoArquivo() + "arq" + (numeroarquivo + 1) + ".txt";
			if (File.Exists(caminho2))
			{
				Arquivos.Ler(numeroarquivo + 1);
			}
			else
			{
				Console.WriteLine("\nTodos os arquivos foram lidos.");
			}
		}
	}
}
