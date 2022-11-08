namespace GameInfantil.Models
{
    public class Images
    {
        public static List<ImageTemplate> GetImages()
        {
            var images = new List<ImageTemplate>
            {
                new ImageTemplate
                {
                    Id = 1,
                    Name = NameImage.Boy,
                    Url = "/Assets/boy.png",
                },

                new ImageTemplate
                {
                    Id = 2,
                    Name = NameImage.Girl,
                    Url = "/Assets/girl.jpg",
                },

                new ImageTemplate
                {
                    Id = 3,
                    Name = NameImage.Fire,
                    Url = "/Assets/fire.jpg",
                },

                new ImageTemplate
                {
                    Id = 4,
                    Name = NameImage.Water,
                    Url = "/Assets/water.jpg",
                }
            };

            return images;
        }
    }

    public class ImageTemplate
    {
        public NameImage Name { get; set; }
        public string? Url { get; set; }
        public int Id { get; set; }
    }

    public enum NameImage
    {
        Boy = 1,
        Girl = 2,
        Fire = 3,
        Water = 4
    }
}
