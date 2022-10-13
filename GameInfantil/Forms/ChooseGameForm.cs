namespace GameInfantil.Forms
{
    public partial class ChooseGameForm : Form
    {
        public ChooseGameForm()
        {
            InitializeComponent();
        }

        private void ButtonQuizGame_Click(object sender, EventArgs e)
        {
            Hide();

            var quiz = new QuizForm();
            quiz.Show();
        }

        private void ButtonMemoryGame_Click(object sender, EventArgs e)
        {
            Hide();

            var memoryGame = new MemoryGameForm();
            memoryGame.Show();
        }
    }
}
