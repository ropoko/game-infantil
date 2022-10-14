namespace GameInfantil.Models
{
    public class Images
    {
        public static List<ImageTemplate> GetImages()
        {
            var images = new List<ImageTemplate>();

            images.Add(new ImageTemplate
            {
                Id = 1,
                Name = "Boy",
                Url = "/Assets/boy.png",
            });

            images.Add(new ImageTemplate
            {
                Id = 2,
                Name = "Girl",
                Url = "/Assets/girl.jpg",
            });

            images.Add(new ImageTemplate
            {
                Id = 3,
                Name = "Fire",
                Url = "/Assets/fire.jpg",
            });

            images.Add(new ImageTemplate
            {
                Id = 4,
                Name = "Water",
                Url = "/Assets/water.jpg",
            });

            return images;
        }
    }

    public class ImageTemplate
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
        public int Id { get; set; }
    }
}
