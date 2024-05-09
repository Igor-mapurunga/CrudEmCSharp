using Crud;

Cliente cliente = new Cliente();
List<Cliente> ClientesCadastrados = new List<Cliente>();

Cliente cliente2 = new Cliente();
cliente2.Nome = "Carlos";
cliente2.Cpf = "123";
cliente2.Email = "carlosdourado@gmail.com";

ClientesCadastrados.Add(cliente2);


void ExibirOpcoesDoMenu()
{
    Console.WriteLine("BEM VINDO AO MEU SISTEMA DE CADASTRO DE CLIENTES");
    Console.WriteLine();
    Console.WriteLine("DIGITE 1 PARA CADASTRAR UM NOVO CLIENTE");
    Console.WriteLine();
    Console.WriteLine("DIGITE 2 PARA EXIBIR UM CLIENTE");
    Console.WriteLine();
    Console.WriteLine("DIGITE 3 PARA ATUALIZAR UM CLIENTE");
    Console.WriteLine();
    Console.WriteLine("DIGITE 4 PARA DELETAR UM CLIENTE");
    Console.WriteLine();
    Console.WriteLine("DIGITE 5 PARA SAIR DO PROGRAMA");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            cliente.cadastrarCliente(ClientesCadastrados, cliente);
            break;
        case 2:
            cliente.exibirClienteCadastrado(ClientesCadastrados);
            break;
        case 3:
            cliente.atualizarNomeDoCliente(ClientesCadastrados);
            break;
        case 4:
            cliente.excluirCliente(ClientesCadastrados);
            break;
        case 5:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

ExibirOpcoesDoMenu();
   




