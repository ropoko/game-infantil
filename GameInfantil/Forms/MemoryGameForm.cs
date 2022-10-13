using System;

namespace GameInfantil.Forms
{
    public partial class MemoryGameForm : Form
    {
        public MemoryGameForm()
        {
            InitializeComponent();
        }

        // Adiciona imagens padrão
        private void MemoryGameForm_Load(object sender, EventArgs e)
        {
            string basePath = AppContext.BaseDirectory;

            Card1.Image = Image.FromFile($"{basePath}/Assets/default.png");
            Card1.SizeMode = PictureBoxSizeMode.StretchImage;

            Card2.Image = Image.FromFile($"{basePath}/Assets/default.png");
            Card2.SizeMode = PictureBoxSizeMode.StretchImage;

            Card3.Image = Image.FromFile($"{basePath}/Assets/default.png");
            Card3.SizeMode = PictureBoxSizeMode.StretchImage;

            Card4.Image = Image.FromFile($"{basePath}/Assets/default.png");
            Card4.SizeMode = PictureBoxSizeMode.StretchImage;

            Card5.Image = Image.FromFile($"{basePath}/Assets/default.png");
            Card5.SizeMode = PictureBoxSizeMode.StretchImage;

            Card6.Image = Image.FromFile($"{basePath}/Assets/default.png");
            Card6.SizeMode = PictureBoxSizeMode.StretchImage;
            
            Card7.Image = Image.FromFile($"{basePath}/Assets/default.png");
            Card7.SizeMode = PictureBoxSizeMode.StretchImage;
            
            Card8.Image = Image.FromFile($"{basePath}/Assets/default.png");
            Card8.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
