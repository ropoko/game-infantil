using GameInfantil.Models;
using GameInfantil.Utils;
using System.Net.Security;

namespace GameInfantil.Forms
{
    public partial class QuizForm : Form
    {
        private int _actualQuestion = 0;

        private int _points = 0;

        private readonly List<QuizQuestion> _quizQuestions = Questions.GetQuestions();

        public QuizForm()
        {
            InitializeComponent();
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            GetQuestion();

            LabelPoints.Text = _points.ToString();

            BackgroundImage = Image.FromFile($"{AppContext.BaseDirectory}/Assets/background.png");

            ButtonHome.Image = Image.FromFile($"{AppContext.BaseDirectory}/Assets/home.png");
            ButtonHome.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Points(QuizQuestion question)
        {
            QuizAnswer? optionSelected = Option1.Checked ? question.Option1
                : Option2.Checked ? question.Option2
                : Option3.Checked ? question.Option3
                : question.Option4;

            if (optionSelected!.IsCorrect)
            {
                _points += 100;
                LabelPoints.Text = _points.ToString();
            }
        }

        private void ButtonNextQuestion_Click(object sender, EventArgs e)
        {
            Points(_quizQuestions[_actualQuestion]);

            _actualQuestion++;
            GetQuestion();


            Option3.Visible = !string.IsNullOrEmpty(Option3.Text);

            Option4.Visible = !string.IsNullOrEmpty(Option4.Text);
        }

        private void GetQuestion()
        {
            if (_quizQuestions.Count == _actualQuestion)
            {
                HandleFinishQuiz();
                return;
            }

            LabelQuestion.Text = _quizQuestions[_actualQuestion].Question;

            Option1.Text = _quizQuestions[_actualQuestion].Option1?.Text;
            Option2.Text = _quizQuestions[_actualQuestion].Option2?.Text;
            Option3.Text = _quizQuestions[_actualQuestion].Option3?.Text;
            Option4.Text = _quizQuestions[_actualQuestion].Option4?.Text;
        }

        private void HandleFinishQuiz()
        {
            Hide();

            var finish = new FinishForm("Parabéns, Você finalizou o Quiz!!", _points);
            finish.Show();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            Hide();

            var main = new MainForm();
            main.Show();
        }
    }
}
