using GameInfantil.Forms;

namespace GameInfantil
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonChooseGame_Click(object sender, EventArgs e)
        {
            Hide();

            var chooseGame = new ChooseGameForm();
            chooseGame.Show();
        }

        private void ButtonHowToPlay_Click(object sender, EventArgs e)
        {
            Hide();

            var howToPlay = new HowToPlayForm();
            howToPlay.Show();
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            Hide();

            var about = new AboutForm();
            about.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile($"{AppContext.BaseDirectory}/Assets/background.png");
        }

        private void ButtonCredits_Click(object sender, EventArgs e)
        {
            Hide();

            var credits = new CreditsForm();
            credits.Show();
        }
    }
}
