using System.ComponentModel.DataAnnotations;

namespace Store.Shared.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }

        public Rol? Rol { get; set; }

        [Required]
        public int RolId { get; set; }
    }
}