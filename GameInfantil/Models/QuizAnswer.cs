namespace GameInfantil.Models
{
    /// <summary>
    /// Define um tipo padrão para as respostas - contendo o texto 
    /// que será exibido e se é a resposta correta ou não
    /// </summary>
    public class QuizAnswer
    {
        public string? Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}
