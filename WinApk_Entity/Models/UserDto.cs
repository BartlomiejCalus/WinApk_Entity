using System.ComponentModel.DataAnnotations;

namespace WinApk_Entity.Models
{
    public class UserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        public string RoleName { get; set; }
        public int RoleId { get; set; }
    }
}
