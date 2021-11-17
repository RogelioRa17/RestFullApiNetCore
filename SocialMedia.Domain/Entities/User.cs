using System;
using System.Collections.Generic;

#nullable disable

namespace SocialMedia.Domain.Entities
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            Posts = new HashSet<Post>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
