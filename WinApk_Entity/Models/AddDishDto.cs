using System.ComponentModel.DataAnnotations;

namespace WinApk_Entity.Models
{
    public class AddDishDto
    {
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public double Prize { get; set; }
    }
}
