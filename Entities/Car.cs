using System.ComponentModel.DataAnnotations;

namespace Alta.Entities
{
    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; } = string.Empty;


        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; } = string.Empty;


        [Required(ErrorMessage = "Short Description is Required")]
        public string ShortDescription { get; set; } = string.Empty;


        [Required(ErrorMessage = "Image Url is Required")]
        public string ImageSrc { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is Required")]
        public double Price { get; set; }
    }
}
