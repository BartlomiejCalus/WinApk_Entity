using System.ComponentModel.DataAnnotations;

namespace WinApk_Entity.Models
{
    public class AddRestaurantDto
    {
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PostCode { get; set; }
    }
}
