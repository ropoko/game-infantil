namespace GameInfantil.Forms
{
    public partial class HowToPlayForm : Form
    {
        public HowToPlayForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            var main = new MainForm();
            main.Show();
        }

        private void HowToPlayForm_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile($"{AppContext.BaseDirectory}/Assets/background.png");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
