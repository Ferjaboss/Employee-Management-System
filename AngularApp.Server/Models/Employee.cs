using System.ComponentModel.DataAnnotations;

namespace AngularApp.Server.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string JobTitle { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        // Foreign Key for Department
        public int DepartmentId { get; set; }

        // Navigation Property
        public Department Department { get; set; }
    }
}
