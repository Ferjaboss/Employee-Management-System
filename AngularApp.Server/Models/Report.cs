using System.ComponentModel.DataAnnotations;

namespace AngularApp.Server.Models
{
    public class Report
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ReportType { get; set; } // e.g., "EmployeeByDepartment", "HiredEmployees"

        [Required]
        public DateTime GeneratedOn { get; set; }

        [Required]
        public string GeneratedBy { get; set; } // Username of the user who generated the report

        public string ReportData { get; set; } // JSON or serialized data of the report
    }
}
