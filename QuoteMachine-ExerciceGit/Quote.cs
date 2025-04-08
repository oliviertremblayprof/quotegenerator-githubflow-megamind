namespace QuoteMachine_ExerciceGit
{
    public class Quote
    {
        public required string Text { get; set; }
        public required string Author { get; set; }

        public override string ToString()
        {
            return $"\"{Text}\" - {Author}";
        }
    }
}
