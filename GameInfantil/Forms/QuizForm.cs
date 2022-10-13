using GameInfantil.Models;
using GameInfantil.Utils;

namespace GameInfantil.Forms
{
    public partial class QuizForm : Form
    {
        private int _actualQuestion = 0;

        private readonly List<QuizQuestion> _quizQuestions = Questions.GetQuestions();

        public QuizForm()
        {
            InitializeComponent();
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
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
            return;
        }
    }
}
