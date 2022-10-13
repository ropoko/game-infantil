using GameInfantil.Models;

namespace GameInfantil.Utils
{
    public class Questions
    {
        public static List<QuizQuestion> GetQuestions()
        {
            var questions = new List<QuizQuestion>();

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "Por quê não podemos brincar com fogo?",
                Option1 = new QuizAnswer
                {
                    Text = "Ele pode nos congelar",
                    IsCorrect = false
                },
                Option2 = new QuizAnswer
                {
                    Text = "Ele pode nos queimar",
                    IsCorrect = true
                },
                Option3 = new QuizAnswer
                {
                    Text = "Ele irá ficar bravo comigo",
                    IsCorrect = false
                },
                Option4 = new QuizAnswer
                {
                    Text = "Ele irá morrer por causa disso",
                    IsCorrect = false
                }
            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "Como podemos nos prevenir do fogo?",
                Option1 = new QuizAnswer
                {
                    Text = "Ficar olhando até ele apagar",
                    IsCorrect = false
                },
                Option2 = new QuizAnswer
                {
                    Text = "Jogar folhas secas em cima do fogo",
                    IsCorrect = false
                },
                Option3 = new QuizAnswer
                {
                    Text = "Se jogar em cima do fogo para apagá-lo",
                    IsCorrect = false
                },
                Option4 = new QuizAnswer
                {
                    Text = "Ficando longe de lugares que utilizam fogo",
                    IsCorrect = true
                }
            });

            questions.Add(new QuizQuestion
            {
                Answered = false,
                Question = "Quando vejo uma situação de incêndio ou uma área com fogo, o quê devo fazer?",
                Option1 = new QuizAnswer
                {
                    Text = "Pedir ajuda para um adulto.",
                    IsCorrect = true
                },
                Option2 = new QuizAnswer
                {
                    Text = "Agir sozinho e tentar apagar o fogo",
                    IsCorrect = false
                },
                Option3 = new QuizAnswer
                {
                    Text = "Se aproximar mais para olhar o fogo",
                    IsCorrect = false
                },
                Option4 = new QuizAnswer
                {
                    Text = "Chamar meu animal de estimação",
                    IsCorrect = false
                }
            });

            return questions;
        }
    }
}
