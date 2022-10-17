namespace GameInfantil.Forms
{
    public partial class FinishForm : Form
    {
        private readonly string _message;

        public FinishForm(string message)
        {
            _message = message;
            InitializeComponent();
        }

        private void FinishForm_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile($"{AppContext.BaseDirectory}/Assets/background.png");
            LabelFinishMessage.Text = _message;
        }
    }
}
