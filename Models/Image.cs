using System.ComponentModel.DataAnnotations;

namespace _2024_airbnb_herkansing.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        public string? Description { get; set; }
        public string? Url { get; set; }
        public bool? IsCover { get; set; }
    }

   /* public static class ImageSeed
    {
        public static Image[] GetImages()
        {
            return [
                new Image
                {
                    ImageId = 1,
                    Url = "avatar_landlord_2.jpg",
                    Description = "Avatar of Landlord 1",
                    IsCover = true,
                },
                new Image
                {
                    ImageId = 2,
                    Url = "avatar_landlord_2.jpg",
                    Description = "Avatar of Landlord 2",
                    IsCover = true,                   
                },
                new Image
                {
                    ImageId = 3,
                    Url = "image_location_1.jpg",
                    Description = "Image of location 1",
                    IsCover = true,
                },
                new Image
                {
                    ImageId = 3,
                    Url = "image_location_2.jpg",
                    Description = "Image of location 2",
                    IsCover = true,
                },
            ];

        }*/
    //}
}
