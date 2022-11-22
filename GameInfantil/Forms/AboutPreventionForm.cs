namespace GameInfantil.Forms
{
    public partial class AboutPreventionForm : Form
    {
        public AboutPreventionForm()
        {
            InitializeComponent();
        }

        private void AboutPreventionForm_Load(object sender, EventArgs e)
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
