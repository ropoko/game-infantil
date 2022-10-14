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

        // Adiciona imagens padrão
        private void MemoryGameForm_Load(object sender, EventArgs e)
        {
            SetDefaultImage();
        }

        private void FlipCard(object sender, EventArgs e)
        {
            var image = (PictureBox)sender;

            if (image.Image == image.InitialImage)
            {
                image.Image = Image.FromFile(_defaultImage);
                cardsFlipped++;
            }
            else
            {
                image.Image = image.InitialImage;
                cardsFlipped--;
            }
        }
    }
}
