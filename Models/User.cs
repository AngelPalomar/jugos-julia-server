using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace jugos_julia_server.Models
{
    [Index(nameof(Phone), IsUnique = true)]
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