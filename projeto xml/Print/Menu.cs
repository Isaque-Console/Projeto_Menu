using System;
using System.Collections.Generic;
using System.Text;
using Calculo;
using Classes;
using Diretorio;
using Funcoes;

namespace Print 
{
    class Menu
    {
		public const int SAIDA_PROGRAMA = 0;
		public const int LER_ARQUIVOS = 1;
		public const int TABUADA = 2;
		public const int CALCULAR_MEDIA = 3;
		public const int CADASTRAR_CLIENTE = 4;
		public static void Tela()
		{
			string MensagemMenu = "Olá usuário,seja bem vindo ao programa. \n\n  PROGRAMAÇÃO FUNCIONAL" +
					"\n\n  Digite uma das opções abaixo:" +
					"\n\n" +
					"\n      0 - Sair do programa" +
					"\n      1 - ler arquivos" +
					"\n      2 - Executar a tabuada" +
					"\n      3 - Calcular a média do aluno" +
					"\n      4 - Cadastrar Clientes";

			while (true)
			{
				Console.WriteLine(MensagemMenu);
				int operacao = int.Parse(Console.ReadLine());
				if (operacao == SAIDA_PROGRAMA)
				{
					break;
				}
				else if (operacao == LER_ARQUIVOS)
				{
					Console.WriteLine("========================opção Ler arquivo==============================");
					Arquivos.Ler(1);
					Console.WriteLine("=======================================================================");
				}
				else if (operacao == TABUADA)
				{
					Console.WriteLine("========================opção Tabuada==================================");
					Console.WriteLine("Digite o número que deve ser calculada a sua tabuada: \n");
					int valor = int.Parse(Console.ReadLine());
					Tabuada.Numero(valor);
					Console.WriteLine("=======================================================================");
				}
				else if (operacao == CALCULAR_MEDIA)
				{
					Console.WriteLine("==========================opção Média do aluno=========================");
					Console.WriteLine("Digite a quantidade de notas desse aluno: \n");
					int quantidade = int.Parse(Console.ReadLine());
					Media.Aluno(quantidade);
				}
				else if (operacao == CADASTRAR_CLIENTE)
				{
					TelaCliente.Chamar();
					Console.WriteLine("\n=================================================");
				}
				else
				{
					Console.WriteLine("Digite uma opção válida\n");
				}
			}
		}
	}
}
