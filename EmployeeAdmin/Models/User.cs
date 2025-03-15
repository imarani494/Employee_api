using System.ComponentModel.DataAnnotations;

namespace EmployeeAdmin.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public required string Username { get; set; }

        [Required]
        public  required string Password { get; set; }
    }
}
