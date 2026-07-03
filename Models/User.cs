using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SenacPDV.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(1), MaxLength(50)]
        public string Username { get; set; }

        [Required, MinLength(1), MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //Relacionamento muitos-para-muitos com role
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
