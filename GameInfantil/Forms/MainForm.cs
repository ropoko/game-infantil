using GameInfantil.Forms;

namespace GameInfantil
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // leva para a tela de escolher o tipo de jogo
        private void ButtonChooseGame_Click(object sender, EventArgs e)
        {
            Hide();

            var chooseGame = new ChooseGameForm();
            chooseGame.Show();
        }

        // leva para a tela de "como jogar?"
        private void ButtonHowToPlay_Click(object sender, EventArgs e)
        {
        }

        // leva para a tela da descrição do projeto
        private void ButtonAbout_Click(object sender, EventArgs e)
        {
        }
    }
}
