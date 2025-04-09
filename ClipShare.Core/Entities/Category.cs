using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClipShare.Core.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
        public int SortOrder { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        // Navigation properties
        public virtual ICollection<Category> SubCategories { get; set; } = new List<Category>();
    }
}
