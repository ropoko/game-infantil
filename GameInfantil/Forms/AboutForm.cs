namespace GameInfantil.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile($"{AppContext.BaseDirectory}/Assets/background.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            var main = new MainForm();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();

            var accident = new AboutAccidentForm();
            accident.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();

            var prevention = new AboutPreventionForm();
            prevention.Show();
        }
    }
}
