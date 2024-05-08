// Screen Sound 

String mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Pink Floyd", "Cake"};
Dictionary<string, List<int>> listaDasBandas = new Dictionary<string, List<int>>();
listaDasBandas.Add("Linkin Park", new List<int> { 10, 8, 6 });
listaDasBandas.Add("Beatles", new List<int> { 10 });
listaDasBandas.Add("Creedence Clearwater Revival", new List<int> { 5, 10, 7 });
listaDasBandas.Add("U2", new List<int> { 5, 10, 6 });

void ExibirLogo()
{
    Console.Clear();
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");

}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("Digite 1 para cadastrar uma banda");
    Console.WriteLine("Digite 2 mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    ExibirLogo();
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ListarBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case 0:
            Console.WriteLine("\nFim da Execução!");
            break;
        default:
            Console.Write("\nOpção inválida! Tecle <Enter> para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
            ExibirLogo();
            ExibirOpcoesDoMenu();
            break;
    }
}

void RegistrarBanda()
{
    Console.Write("Digite o nome da banda que quer cadastrar: ");
    string nomeDaBanda = Console.ReadLine()!;

    //listaDasBandas.Add(nomeDaBanda);
    listaDasBandas.Add( nomeDaBanda, new List<int>() );

    Console.WriteLine($"\nA banda {nomeDaBanda} foi cadastrada com sucesso...");
    Thread.Sleep(2000);
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void ListarBandas()
{
    Console.WriteLine("Bandas cadastradas: \n");

    foreach (string banda in listaDasBandas.Keys)
    {
        Console.WriteLine($"       * {banda}");
    }

    Console.Write("\n\nTecle <Enter> para voltar ao menu");
    Console.ReadKey();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void AvaliarBanda()
{
    // Escolher banda para avaliar

    //ListarBandas();
    //Console.Write("Digite o número da banda que quer avaliar : ");
    //int banda = int.Parse( Console.ReadLine() )!;

    Console.Write("Digite o nome da banda para avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (listaDasBandas.ContainsKey(nomeDaBanda))
    {
        // Atribuir nota para a banda escolhida

        Console.Write($"\nDigite sua nota para a banda '{nomeDaBanda}': ");
        int nota = int.Parse(Console.ReadLine()!);
        listaDasBandas[nomeDaBanda].Add(nota);
        Console.Write($"\nA nota '{nota}' foi atribuida para a banda '{nomeDaBanda}'...");
        Thread.Sleep(2000);
    }
    else
    {
        Console.Write($"\nBanda '{nomeDaBanda}' não encontrada! Tecle <Enter> para voltar ao menu");
        Console.ReadKey();
    }

    // Voltar ao menu principal
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void ExibirMedia()
{
    // Escolher banda para avaliar
    Console.WriteLine("Bandas cadastradas: \n");
    foreach (string banda in listaDasBandas.Keys)
    {
        Console.WriteLine($"       * {banda}");
    }
    Console.Write("\nDigite o nome da banda para exibir a média das avaliações: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (listaDasBandas.ContainsKey(nomeDaBanda))
    {
        // Exibir a média
        double media = listaDasBandas[nomeDaBanda].Average();
        Console.WriteLine($"\n       * Banda: {nomeDaBanda}");
        Console.WriteLine($"       * Nota média: {media}");
        Console.Write("\n\nTecle <Enter> para voltar ao menu");
        Console.ReadKey();
    }
    else
    {
        Console.Write($"\nBanda '{nomeDaBanda}' não encontrada! Tecle <Enter> para voltar ao menu");
        Console.ReadKey();
    }

    // Voltar ao menu principal
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

ExibirLogo();
Console.WriteLine(mensagemDeBoasVindas + "\n");
ExibirOpcoesDoMenu();