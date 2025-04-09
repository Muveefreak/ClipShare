using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ClipShare.Core.Entities
{
    public class AppUser : IdentityUser<int>
    {
        [Required]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public string? ProfilePicture { get; set; }
        public string? CoverPicture { get; set; }
        public string? Bio { get; set; }
        public string? Location { get; set; }
        public DateTime? DateOfBirth { get; set; }

        // Navigation properties
        public virtual ICollection<Channel> Channels { get; set; } = new List<Channel>();
    }
}
