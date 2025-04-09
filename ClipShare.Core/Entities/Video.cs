using System;

namespace ClipShare.Core.Entities
{
    public class Video : BaseEntity
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public string VideoUrl { get; set; }
        public int Duration { get; set; } // Duration in seconds
        public int ViewCount { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public int AppUserId { get; set; }
        public int CategoryId { get; set; }
        
        
        // Navigation properties
        public AppUser AppUser { get; set; }
        public Category Category { get; set; }
    }
}
