using GameInfantil.Models;

namespace GameInfantil.Forms
{
    public partial class MemoryGameForm : Form
    {
        private readonly List<PictureBox> _cards;

        private readonly string _defaultImage = $"{AppContext.BaseDirectory}/Assets/default.png";

        private int cardsFlipped = 0;

        

        public MemoryGameForm()
        {
            InitializeComponent();

            _cards = new List<PictureBox>()
            {
                Card1,
                Card2,
                Card3,
                Card4,
                Card5,
                Card6,
                Card7,
                Card8
            };
        }

        private void SetDefaultImage()
        {
            string basePath = AppContext.BaseDirectory;

            var randImage = new Random();

            var images = Images.GetImages();

            _cards.ForEach((card) =>
            {
                int n = randImage.Next(1, 4);

                var image = images.First(i => i.Id == n);

                card.InitialImage = Image.FromFile($"{basePath}{image.Url}");

                card.Image = Image.FromFile(_defaultImage);
                card.SizeMode = PictureBoxSizeMode.StretchImage;
            });
        }

        // Add default images
        private void MemoryGameForm_Load(object sender, EventArgs e)
        {
            SetDefaultImage();

            ButtonHome.Image = Image.FromFile($"{AppContext.BaseDirectory}/Assets/home.png");
            ButtonHome.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FlipCard(object sender, EventArgs e)
        {
            var image = (PictureBox)sender;

            if (image.Image == image.InitialImage)
            {
                image.Image = Image.FromFile(_defaultImage);
                cardsFlipped--;
            }
            else
            {
                if (cardsFlipped == 2) return;

                image.Image = image.InitialImage;
                cardsFlipped++;
            }
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            Hide();

            var main = new MainForm();
            main.Show();
        }
    }
}
