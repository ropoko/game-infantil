namespace GameInfantil.Forms
{
    public partial class AboutAccidentForm : Form
    {
        public AboutAccidentForm()
        {
            InitializeComponent();
        }

        private void AboutAccidentForm_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile($"{AppContext.BaseDirectory}/Assets/background.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            var main = new MainForm();
            main.Show();
        }
    }
}
