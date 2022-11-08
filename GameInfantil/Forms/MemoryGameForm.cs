using GameInfantil.Models;

namespace GameInfantil.Forms
{
    public partial class MemoryGameForm : Form
    {
        private readonly string _basePath = AppContext.BaseDirectory;

        private readonly List<PictureBox> _cards;

        private readonly string _defaultImage = $"{AppContext.BaseDirectory}/Assets/default.png";

        private int _cardsFlipped = 0;

        private int _countFireCard = 0;
        private int _countWaterCard = 0;
        private int _countBoyCard = 0;
        private int _countGirlCard = 0;

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
            var randImage = new Random();

            var images = Images.GetImages();

            _cards.ForEach((card) =>
            {
                int n = randImage.Next(1, 4);

                var image = images.First(i => i.Id == n);

                AddImage(card, image);

                card.Image = Image.FromFile(_defaultImage);
                card.SizeMode = PictureBoxSizeMode.StretchImage;
            });
        }

        private void AddImage(PictureBox card, ImageTemplate img)
        {
            switch (img.Name)
            {
                case NameImage.Girl:
                    if (_countGirlCard == 2) goto case NameImage.Boy;
                    else
                    {
                        _countGirlCard++;
                        card.InitialImage = Image.FromFile($"{_basePath}{Images.GetImages().First(p => p.Id == 2).Url}");
                    }
                    break;
                case NameImage.Boy:
                    if (_countBoyCard == 2) goto case NameImage.Fire;
                    else
                    {
                        _countBoyCard++;
                        card.InitialImage = Image.FromFile($"{_basePath}{Images.GetImages().First(p => p.Id == 1).Url}");
                    }
                    break;
                case NameImage.Fire:
                    if (_countFireCard == 2) goto case NameImage.Water;
                    else
                    {
                        _countFireCard++;
                        card.InitialImage = Image.FromFile($"{_basePath}{Images.GetImages().First(p => p.Id == 3).Url}");
                    }
                    break;
                case NameImage.Water:
                    if (_countWaterCard == 2) goto case NameImage.Boy;
                    else
                    {
                        _countWaterCard++;
                        card.InitialImage = Image.FromFile($"{_basePath}{Images.GetImages().First(p => p.Id == 4).Url}");
                    }
                    break;
            }
        }

        private void MemoryGameForm_Load(object sender, EventArgs e)
        {
            SetDefaultImage();

            ButtonHome.Image = Image.FromFile($"{AppContext.BaseDirectory}/Assets/home.png");
            ButtonHome.SizeMode = PictureBoxSizeMode.StretchImage;

            LabelPoints.Text = "0";
        }

        private void FlipCard(object sender, EventArgs e)
        {
            var image = (PictureBox)sender;

            if (image.Image == image.InitialImage)
            {
                image.Image = Image.FromFile(_defaultImage);
                _cardsFlipped--;
            }
            else
            {
                //if (_cardsFlipped == 2)
                //{
                //    _cards.ForEach((card) =>
                //    {
                //        card.Image = Image.FromFile(_defaultImage);
                //    });

                //    return;
                //}

                image.Image = image.InitialImage;
                _cardsFlipped++;
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
