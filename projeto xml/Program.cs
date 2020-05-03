using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Classes;
using Print;

namespace Projeto
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Menu.Tela();
			var MostrarDadosDosClientesDidatico = Cliente.LerClientes();
			/*
			var individuo1 = new Cliente();
			individuo1.Nome = "isaque";
			individuo1.Telefone = "786543515984";
			individuo1.CPF = "159753456";
			individuo1.Gravar();

			var individuo2 = new Cliente();
			individuo2.Nome = "rozana";
			individuo2.Telefone = "12333464523554";
			individuo2.CPF = "45654876854521";
			individuo2.Gravar();
			*/
		}
	}
}