using System.ComponentModel.DataAnnotations;

namespace Store.Shared.Entities
{
    public class Rol
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        // Genericos Ususario

        public ICollection<User>? Users { get; set; }

        public int UserCount => Users == null ? 0 : Users.Count(); // lectura
    }
}