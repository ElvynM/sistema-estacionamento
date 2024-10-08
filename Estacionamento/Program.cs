
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n");

Console.WriteLine("Digite o preço inicial:");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço por hora:");
decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento.Models.Estacionamento estacionamento = new Estacionamento.Models.Estacionamento(precoInicial, precoPorHora);


bool continuar = true;
while (continuar)
{
    Console.WriteLine("\nDigite a sua opção:");
    Console.WriteLine("1 - Adicionar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    string opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo();
            break;
        case "3":
            estacionamento.ListarVeiculos();
            break;
        case "4":
            continuar = false;
            Console.WriteLine("Encerrando o programa...");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
