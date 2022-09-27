﻿using GameInfantil.Models;

namespace GameInfantil.Forms
{
    public partial class QuizForm : Form
    {
        private int _actualQuestion = 0;

        private readonly List<QuizQuestion> _quizQuestions = new();

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

            _quizQuestions.Add(new QuizQuestion
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

            GetQuestion();
        }

        private void ButtonNextQuestion_Click(object sender, EventArgs e)
        {
            _actualQuestion++;
            GetQuestion();
        }

        private void GetQuestion()
        {
            if (_quizQuestions.Count == _actualQuestion)
                HandleFinishQuiz();

            LabelQuestion.Text = _quizQuestions[_actualQuestion].Question;

            Option1.Text = _quizQuestions[_actualQuestion].Option1?.Text;
            Option2.Text = _quizQuestions[_actualQuestion].Option2?.Text;
            Option3.Text = _quizQuestions[_actualQuestion].Option3?.Text;
            Option4.Text = _quizQuestions[_actualQuestion].Option4?.Text;
        }

        private void HandleFinishQuiz()
        {

        }
    }
}
