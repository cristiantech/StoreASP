using System.ComponentModel.DataAnnotations;

namespace Store.Shared.Entities

{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public String Name { get; set; } = null;

        public String? Address { get; set; }

        public Rol IdCountry { get; set; }
    }
}