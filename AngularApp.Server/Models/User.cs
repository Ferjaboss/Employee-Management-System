﻿using System.ComponentModel.DataAnnotations;

namespace AngularApp.Server.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public Role Role { get; set; }
    }

    public enum Role
    {
        Admin,
        HRManager,
        Employee
    }
}
