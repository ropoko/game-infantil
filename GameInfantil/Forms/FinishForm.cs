namespace GameInfantil.Forms
{
    public partial class FinishForm : Form
    {
        private readonly string _message;

        private readonly int _points;

        public FinishForm(string message, int points)
        {
            _message = message;
            _points = points;

            InitializeComponent();
        }

        private void FinishForm_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile($"{AppContext.BaseDirectory}/Assets/background.png");
            LabelFinishMessage.Text = _message;

            LabelScore.Text = $"{_points} pontos!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            var main = new MainForm();
            main.Show();
        }
    }
}
