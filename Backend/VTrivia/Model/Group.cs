﻿using System.ComponentModel.DataAnnotations;

namespace VTrivia.Model
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        
        public string? AdminId { get; set; }

        public DateTime? TiemStamp { get; set; }
        public List<AppUser>? AppUsers { get; set; }

        public Group()
        {
            AppUsers = new List<AppUser>();
        }

    }
}
