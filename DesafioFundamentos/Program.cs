using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

Ferry ferry = new Ferry();
Console.WriteLine("Seja bem vindo ao sistema de Ferry Boat!\n");

bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Cadastrar pessoa");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Listar pessoas");
    Console.WriteLine("5 - Remover veículo");
    Console.WriteLine("6 - Remover pessoa");
    Console.WriteLine("7 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            ferry.AdicionarVeiculo();
            break;
        case "2":
            ferry.AdicionarPessoa();
            break;
        case "3":
            ferry.ListarVeiculos();
            break;
        case "4":
            ferry.ListarPessoas();
            break;
        case "5":
            ferry.RemoverVeiculo();
            break;
        case "6":
            ferry.RemoverPessoa();
            break;
        case "7":
            Console.WriteLine("Programa encerrado.");
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla");
    Console.ReadLine();
}

