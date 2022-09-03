using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameInfantil.Forms
{
    public partial class ChooseGameForm : Form
    {
        public ChooseGameForm()
        {
            InitializeComponent();
        }

        // abre a tela de quiz
        private void ButtonQuizGame_Click(object sender, EventArgs e)
        {
            Hide();

            var quiz = new QuizForm();
            quiz.Show();
        }

        // abre a tela do jogo da memória
        private void ButtonMemoryGame_Click(object sender, EventArgs e)
        {

        }
    }
}
