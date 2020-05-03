using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente
    {
		/// <summary>
		/// Construtor da classe: Cliente
		/// </summary>
		/// <param name="_nome">input no nome</param>
		/// <param name="_telefone">input no número de telefone</param>
		/// <param name="_cpf">input no número de CPF</param>
		public Cliente(string _nome,string _telefone, string _cpf)
		{
			this.Nome = _nome;
			this.Telefone = _telefone;
			this.CPF = _cpf;
		}
		private static string caminhoBaseClientes()
		{
			return ConfigurationManager.AppSettings["BaseDosClientes"];
		}

		public Cliente()
		{

		}

		public string Nome;
        public string Telefone;
        public string CPF;
        public void Gravar()
        {
			var GravarDados = Cliente.LerClientes();
			GravarDados.Add(this);
			if (File.Exists(caminhoBaseClientes()))
			{
				StreamWriter r = new StreamWriter(caminhoBaseClientes());
				r.WriteLine("Nome;Telefone;CPF;");
				foreach(Cliente c in GravarDados)
				{
					var linha = c.Nome + ";" + c.Telefone + ";" + c.CPF + ";";
					r.WriteLine(linha);
				}
				r.Close();
			}
        }
		public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
			if (File.Exists(caminhoBaseClientes()))
			{
				using (StreamReader arquivo = File.OpenText(caminhoBaseClientes()))
				{
					string linha;
					int i = 0;
					while ((linha = arquivo.ReadLine()) != null)
					{
						i++;
						if (i == 1) continue;
						var ArquivoCliente = linha.Split(';');
						var cliente = new Cliente(ArquivoCliente[0], ArquivoCliente[1], ArquivoCliente[2]);
						clientes.Add(cliente);
					}
					/*Console.WriteLine("Existe(m) " + clientes.Count + " cliente(s) cadastrado(s). Seus dados são: \n");
					for(int j = 0;j<clientes.Count;j++)
					{
						Console.WriteLine("===============================================");
						Console.WriteLine("Nome: " + clientes[j].Nome + "\n");
						Console.WriteLine("Telefone: " + clientes[j].Telefone + "\n");
						Console.WriteLine("CPF: " + clientes[j].CPF + "\n");
						Console.WriteLine("===============================================");
					}*/
				}
			}
			return clientes;
        }
    }
}
