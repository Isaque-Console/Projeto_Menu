using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Funcoes
{
    class TelaCliente
    {
        public static void Chamar()
        {
            Console.WriteLine("=====================cadastro de cliente================");
            while (true)
            {
                string MensagemCadastro = "Olá usuário,seja bem vindo ao programa. \n\n  PROGRAMAÇÃO FUNCIONAL" +
                    "\n\n  Digite uma das opções abaixo:" +
                    "\n\n" +
                    "\n      0 - Sair do cadastro" +
                    "\n      1 - Para cadastrar clientes" +
                    "\n      2 - Listar Clientes";

                Console.WriteLine(MensagemCadastro);
                
                int answer = int.Parse(Console.ReadLine());

                if(answer == 0)
                {
                    break;
                }
                else if(answer == 1)
                {
                    var cliente = new Cliente();
                    Console.WriteLine("Digite o nome do cliente: \n");
                    cliente.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o número do telefone do cliente: \n");
                    cliente.Telefone = Console.ReadLine();
                    Console.WriteLine("Digite o CPF do cliente: \n");
                    cliente.CPF = Console.ReadLine();

                    cliente.Gravar();
                }
                else if (answer == 2)
                {
                    var clientes = Cliente.LerClientes();
                    foreach (Cliente c in clientes)
                    {
                        Console.WriteLine(c.Nome + c.Telefone + c.CPF);
                    }
                }
                else
                {
                    Console.WriteLine("Por favor,digite uma opção válida");
                }
            }
        }
    }
}
