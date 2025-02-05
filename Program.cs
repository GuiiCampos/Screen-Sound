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
            case 3: Console.WriteLine("3"); break;//AvaliarBanda(); break;
            case 4: Console.WriteLine("4"); break;//MediaDasBandas(); break;
            case 0: Console.Write("Programa Encerrado"); return;
            default:    
                Console.Write("Opção invalida");
                break;
        }
    }
}
void ExibirTitleDaOpcao(string titulo) {
    string asteriscos = new string('*', titulo.Length);
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

Boolean ListaVazia() {
    if(allBandas.Count == 0) {
        Console.WriteLine("Lista vazia, adicione alguma banda.");
        Thread.Sleep(2000);
        return true;
    }
    return false;
}

void EsperarTecla() {
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
    Console.ReadKey();
}

void RegistraBanda() {
    Console.Clear();
    ExibirTitleDaOpcao("Registro de Bandas");

    Console.Write("\nNome da banda: ");
    string nomeBanda = Console.ReadLine()!;

    if (allBandas.ContainsKey(nomeBanda)) {
        Console.WriteLine("Esta banda já foi cadastrada!");
    } else {
        allBandas.Add(nomeBanda, new List<int>());
        Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    }

    Thread.Sleep(2000);
}

void ShowAllBandas() {
    Console.Clear();

    if (ListaVazia()) return;

    ExibirTitleDaOpcao("Exibindo todas as bandas");

    int i = 1;
    foreach (string banda in allBandas.Keys) {
        Console.WriteLine($"{i++}° banda: {banda}");
    }

    EsperarTecla();
}

ExibirOpcoesMenu();