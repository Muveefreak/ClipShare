using System;
using System.Collections.Generic;

namespace ClipShare.Core.Entities
{
    public class Channel : BaseEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public int AppUserId { get; set; }

        // Navigation properties
        public AppUser AppUser { get; set; }
        public virtual ICollection<Video> Videos { get; set; } = new List<Video>();
        //public virtual ICollection<Playlist> Playlists { get; set; } = new List<Playlist>();
    }
}
