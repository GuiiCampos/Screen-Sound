Dictionary<string, List<int>> allBandas = new Dictionary<string, List<int>>();
allBandas.Add("ACDC", new List<int>{10, 7});
allBandas.Add("Queen", new List<int>{});

void MostrarLogo() {
    Console.WriteLine(@"
        
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine("Boas vindas ao Screen Sound");
    Thread.Sleep(1000);
}

void ExibirOpcoesMenu() {
    while (true) {
        Console.Clear();
        MostrarLogo();
        
        Console.WriteLine("\nMenu de Seleção");

        Console.WriteLine("\n1 - Registrar uma banda");
        Console.WriteLine("2 - Listar todas as banda");
        Console.WriteLine("3 - Avaliar uma banda");
        Console.WriteLine("4 - Exibir a média das bandas");
        Console.WriteLine("0 - Sair");

        Console.Write("\nAguardando: ");

        int opcao = int.Parse(Console.ReadLine()!);

        switch (opcao) {
            case 1: RegistraBanda(); break;
            case 2: ShowAllBandas(); break;
            case 3: AvaliarBanda(); break;
            case 4: MediaDasBandas(); break;
            case 0: Console.Write("Programa Encerrado"); return;
            default:    
                Console.Write("Opção invalida");
                break;
        }
    }
}

ExibirOpcoesMenu();