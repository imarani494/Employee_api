using System.ComponentModel.DataAnnotations;

namespace EmployeeAdmin.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        [Required, EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required DateTime DateOfBirth { get; set; }

        [Required]
        public required string Position { get; set; }

        [Required]
        public decimal Salary { get; set; }
    }
}
