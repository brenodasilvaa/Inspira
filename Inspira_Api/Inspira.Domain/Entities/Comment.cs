using Inspira.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira_Music.Domain.Entities
{
    public class Comment : Entity
    {
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public Post Post { get; set; }
        public User User { get; set; }
    }
}
