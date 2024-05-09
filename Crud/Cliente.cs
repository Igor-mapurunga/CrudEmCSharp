using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }


        public void cadastrarCliente(List<Cliente> ClientesCadastrados, Cliente cliente)
        {
            Console.Clear();
            List<Cliente> clientes = new List<Cliente>();

            Console.WriteLine("Digite o nome do cliente que deseja cadastrar: ");
            string nomeDoCliente = Console.ReadLine();
            cliente.Nome = nomeDoCliente;
            Console.WriteLine("Digite o Email do cliente ");
            string emailDoCliente = Console.ReadLine();
            cliente.Email = emailDoCliente;
            Console.WriteLine("Digite o Cpf do Cliente: ");
            string CpfDoCliente = Console.ReadLine();
            cliente.Cpf = CpfDoCliente;
            ClientesCadastrados.Add(cliente);
            Console.WriteLine("CLIENTE CADASTRADO COM SUCESSO");
            Thread.Sleep(4000);
            Console.Clear();
    
            

        }

        public void exibirClienteCadastrado(List<Cliente> ClientesCadastrados)
        {
            foreach (Cliente clienteCadastrado in ClientesCadastrados)
            {
                Console.WriteLine("Lista de Clientes Cadastrados:");
                Console.WriteLine($"Nome: {clienteCadastrado.Nome}");
                Console.WriteLine($"Email: {clienteCadastrado.Email}");
                Console.WriteLine($"CPF: {clienteCadastrado.Cpf}");
                Console.WriteLine("----------------------");
            }
        }

        public void atualizarNomeDoCliente(List<Cliente> ClientesCadastrados)
        {
            Console.WriteLine("Digite o nome do cliente que deseja atualizar: ");
            string verificarCliente = Console.ReadLine();
            Cliente clienteEncontrado = ClientesCadastrados.FirstOrDefault(c => c.Nome == verificarCliente);

            if (clienteEncontrado != null)
            {
                Console.WriteLine("Qual o nome deve ser inserido ?");
                string novoNome = Console.ReadLine();
                clienteEncontrado.Nome = novoNome;
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }
    }
}
