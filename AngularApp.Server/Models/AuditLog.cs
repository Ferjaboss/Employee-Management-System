using System.ComponentModel.DataAnnotations;

namespace AngularApp.Server.Models
{
    public class AuditLog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Action { get; set; } // e.g., "Create", "Update", "Delete"

        [Required]
        public string EntityName { get; set; } // e.g., "Employee"

        [Required]
        public int EntityId { get; set; } // ID of the affected entity

        [Required]
        public string ChangedBy { get; set; } // Username of the user who made the change

        [Required]
        public DateTime Timestamp { get; set; } // When the change was made

        public string OldValue { get; set; } // Old data (optional, for updates)

        public string NewValue { get; set; } // New data (optional, for updates)
    }
}
