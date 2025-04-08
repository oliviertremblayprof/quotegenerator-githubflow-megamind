namespace QuoteMachine_ExerciceGit
{
    public class QuoteManager
    {
        private List<Quote> _quotes;

        public QuoteManager()
        {
            _quotes = new List<Quote>
            {
                new Quote { Text = "Le succès, c’est d’aller d’échec en échec sans perdre son enthousiasme.", Author = "Winston Churchill" },
                new Quote { Text = "Soyez vous-même, tous les autres sont déjà pris.", Author = "Oscar Wilde" },
                new Quote { Text = "La vie, c’est comme une bicyclette, il faut avancer pour ne pas perdre l’équilibre.", Author = "Albert Einstein" }
            };
        }

        public Quote GetRandomQuote()
        {

            Quote quote = new Quote();
            int minValue = 0;
            int maxValue = _quotes.Count;
            Random rand = new Random();
            quote = _quotes[rand.Next(minValue, maxValue)];
            
            //Avant de commencer, décommenter le test suivant:
            //GetRandomQuote_ShouldReturnNonNullQuote

            //Avant de créer votre PR, faites un git rebase sur main pour vous assurer que vous avez la dernière version du code.
            return quote;
        }

        public bool AddQuote(string text, string author)
        {

            //Avant de commencer, décommenter le test suivant:
            //AddQuote_ShouldIncreaseQuoteCount
            try
            {
                _quotes.Add(new Quote { Text = text, Author = author });
                return true;
            }
            catch (
            Exception ex)
            {
                throw new ArgumentException("Erreur lors de l'ajout de la citation", ex);
            }

            //Avant de créer votre PR, faites un git rebase sur main pour vous assurer que vous avez la dernière version du code.
            //throw new NotImplementedException("À implémenter dans feature/add-quote");
        }

        public void SaveToCSVFile(string path)
        {
            if (IsCSVFile(path) == false)
            {
                throw new QuoteFileException("Erreur lors de la sauvegarde : le fichier doit avoir l'extension .csv");
            }
            Console.WriteLine("[Simulation] On sauvegarderait les citations ici.");
            if (File.Exists(path))
            {
                // Écriture de tous les membres.
                StreamWriter fluxEcriture = new StreamWriter(path, false);
                foreach (var quote in _quotes)
                {
                    fluxEcriture.WriteLine($"{quote.Text};{quote.Author}");
                }
                fluxEcriture.Close();
                Console.WriteLine("Citations sauvegardées !");
            }
            else
            {
                FileStream nouveauFichier = File.Create(path);
                StreamWriter fluxEcriture = new StreamWriter(nouveauFichier);
                foreach (var quote in _quotes)
                {
                    fluxEcriture.WriteLine($"{quote.Text};{quote.Author}");
                }
                fluxEcriture.Close();
                Console.WriteLine("Citations sauvegardées !");
            }
        }

        public void LoadFromCSVFile(string path)
        {
            //Avant de commencer, décommenter les tests suivants:
            //LoadFromFile_ShouldAppendQuotesToList
            //LoadFromFile_ShouldThrowIfFileMissing
            //LoadFromFile_ShouldThrowIfNotInCSVExtension

            //Avant de créer votre PR, faites un git rebase sur main pour vous assurer que vous avez la dernière version du code.

            throw new NotImplementedException("À implémenter dans feature/load-from-file");
        }

        public List<Quote> GetAllQuotes()
        {
            return _quotes; // Pas besoin d'ajouter de test pour cette méthode
        }

        private bool IsCSVFile(string path)
        {
            return path.EndsWith(".csv");
        }
    }
}
