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

        private readonly List<PictureBox> _cardsFound = new();

        private int _points = 0;

        private PictureBox? _lastCard = null;

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
                        card.Tag = "Girl";
                    }
                    break;
                case NameImage.Boy:
                    if (_countBoyCard == 2) goto case NameImage.Fire;
                    else
                    {
                        _countBoyCard++;
                        card.InitialImage = Image.FromFile($"{_basePath}{Images.GetImages().First(p => p.Id == 1).Url}");
                        card.Tag = "Boy";
                    }
                    break;
                case NameImage.Fire:
                    if (_countFireCard == 2) goto case NameImage.Water;
                    else
                    {
                        _countFireCard++;
                        card.InitialImage = Image.FromFile($"{_basePath}{Images.GetImages().First(p => p.Id == 3).Url}");
                        card.Tag = "Fire";
                    }
                    break;
                case NameImage.Water:
                    if (_countWaterCard == 2) goto case NameImage.Boy;
                    else
                    {
                        _countWaterCard++;
                        card.InitialImage = Image.FromFile($"{_basePath}{Images.GetImages().First(p => p.Id == 4).Url}");
                        card.Tag = "Water";
                    }
                    break;
            }
        }

        private void MemoryGameForm_Load(object sender, EventArgs e)
        {
            SetDefaultImage();

            ButtonHome.Image = Image.FromFile($"{AppContext.BaseDirectory}/Assets/home.png");
            ButtonHome.SizeMode = PictureBoxSizeMode.StretchImage;

            LabelPoints.Text = _points.ToString();
        }

        private void FlipCard(object sender, EventArgs e)
        {
            var card = (PictureBox)sender;

            if (card.Image == card.InitialImage)
            {
                card.Image = Image.FromFile(_defaultImage);
                _cardsFlipped--;

                return;
            }
            else
            {
                if (_cardsFlipped == 2)
                {
                    _cards.ForEach((card) =>
                    {
                        if (_cardsFound.SingleOrDefault(c => c == card) == null)
                            card.Image = Image.FromFile(_defaultImage);
                    });

                    _cardsFlipped = 1;
                    card.Image = card.InitialImage;

                    _lastCard = card;

                    return;
                }
                else if (_cardsFlipped == 1)
                {
                    if (_lastCard != null && _lastCard.Tag == card.Tag)
                    {
                        card.Image = card.InitialImage;

                        _cardsFound.Add(_lastCard);
                        _cardsFound.Add(card);

                        _lastCard = null;
                        _cardsFlipped = 0;

                        _points += 100;
                        LabelPoints.Text = _points.ToString();

                        if (_cards.Count == _cardsFound.Count)
                        {
                            Hide();

                            var finish = new FinishForm("Parabéns, Você finalizou o Jogo \n da Memória!!", _points);
                            finish.Show();
                        }
                    }
                    else
                    {
                        _cardsFlipped++;
                        card.Image = card.InitialImage;
                        return;
                    }
                }
                else
                {
                    _cardsFlipped++;
                    card.Image = card.InitialImage;

                    _lastCard = card;

                    return;
                }
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
