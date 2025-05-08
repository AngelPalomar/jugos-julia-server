using System.ComponentModel.DataAnnotations;

namespace jugos_julia_server.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Phone]
        public required string Phone { get; set; }

        [Required]
        [MinLength(6)]
        public required string Password { get; set; }
    }
}