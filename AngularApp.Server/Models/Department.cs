using System.ComponentModel.DataAnnotations;

namespace AngularApp.Server.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
