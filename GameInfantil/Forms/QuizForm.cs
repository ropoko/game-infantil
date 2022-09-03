using GameInfantil.Models;

namespace GameInfantil.Forms
{
    public partial class QuizForm : Form
    {
        private int _actualQuestion = 0;

        private List<QuizQuestion> _quizQuestions = new();

        public QuizForm()
        {
            InitializeComponent();
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            _quizQuestions.Add(new QuizQuestion
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

            _quizQuestions.Add(new QuizQuestion
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

            GetQuestion();
        }

        private void ButtonNextQuestion_Click(object sender, EventArgs e)
        {
            _actualQuestion++;
            GetQuestion();
        }

        private void GetQuestion()
        {
            this.LabelQuestion.Text = _quizQuestions[_actualQuestion].Question;
        }
    }
}
