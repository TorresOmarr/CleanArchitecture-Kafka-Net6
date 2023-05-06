using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.core.Events;

namespace Post.Common.Events
{
    public class CommentAddedEvent : BaseEvent
    {
        public CommentAddedEvent(): base(nameof(CommentAddedEvent))
        {
            
        }

        public Guid CommentId { get; set; }
        public string Comment {get; set; } = null!;
        public string Username { get; set; } = null!;
        public DateTime CommentDate { get; set; }
    }
}