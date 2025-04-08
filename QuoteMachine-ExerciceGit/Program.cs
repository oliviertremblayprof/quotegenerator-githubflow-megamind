using QuoteMachine_ExerciceGit;

Console.WriteLine("Bienvenue dans QuoteMachine!");
Console.WriteLine("Ce projet est collaboratif et utilise le GitHub Flow.");
Console.WriteLine("Développez une application console pour gérer et afficher des citations inspirantes.\n");
Console.WriteLine("Prochaines étapes : implémentez les fonctionnalités dans des branches distinctes.\n");
Console.WriteLine("\n=== Menu Principal ===");
Console.WriteLine("Appuyez sur Enter ");
Console.ReadKey(true);
Menu();
var manager = new QuoteManager();
string path = "citations.csv";

static void ShowRandomQuote(QuoteManager manager)
{
    Console.WriteLine("[Simulation] Une citation aléatoire s’afficherait ici.");
    // Exemple futur : Console.WriteLine(manager.GetRandomQuote());
}

static void AddNewQuote(QuoteManager manager)
{
    Console.WriteLine("Ajout de citation");
    Console.Write("Texte : ");
    var texte = Console.ReadLine();
    Console.Write("Auteur : ");
    var auteur = Console.ReadLine();

    if (manager.AddQuote(texte, auteur))
    {
        Console.WriteLine("Citation ajoutée !");
    }
    else
    {
        Console.WriteLine("Erreur lors de l'ajout de la citation.");
    }
}

static void SaveQuotesToFile(QuoteManager manager)
{
    try
    {
        Console.WriteLine("[Simulation] On sauvegarderait les citations ici.");
        // Exemple futur :
        // manager.SaveToFile("citations.txt");
        //Console.WriteLine("Citations sauvegardées !");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erreur : {ex.Message}");
    }
}

static void LoadQuotesFromFile(QuoteManager manager)
{
    try
    {
        Console.WriteLine("[Simulation] On chargerait les citations ici.");
        // Exemple futur :
        // manager.LoadFromFile("citations.txt");
        //Console.WriteLine("Citations chargées !");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erreur : {ex.Message}");
    }
}



static void Menu()
{
    Console.WriteLine("Bienvenue dans le memu MegaMind");
    
    Console.WriteLine("\n=== Saissez un nombre selon ce que vous aimeriez avoir  ===");
    
    Console.Write("\n=== 1- Voir Une citation au hasard ===");
    Console.Write("\n=== 2- Ajouter une citation ===");
    Console.Write("\n=== 3- Charger les ciations dans un fichier csv===");
    Console.Write("\n=== 4- Sauvegarder les ciations dans un fichier csv ===");
    
    Console.WriteLine("");
    Console.WriteLine("");
    
    Console.WriteLine("Bienvenue dans le memu MegaMind");
    Console.ReadLine();

    
}

