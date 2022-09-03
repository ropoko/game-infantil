namespace GameInfantil.Models
{
    public class QuizQuestion
    {
        public string? Question { get; set; }
        public QuizAnswer? Option1 { get; set; }
        public QuizAnswer? Option2 { get; set; }
        public QuizAnswer? Option3 { get; set; }
        public QuizAnswer? Option4 { get; set; }

        // indica se a pergunta já foi respondida ou não
        public bool Answered { get; set; }
    }
}
