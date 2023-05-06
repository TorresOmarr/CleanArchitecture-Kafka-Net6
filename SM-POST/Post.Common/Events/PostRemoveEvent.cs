using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.core.Events;

namespace Post.Common.Events
{
    public class PostRemoveEvent : BaseEvent
    {
        public PostRemoveEvent() : base(nameof(PostRemoveEvent))
        {
        }
        public int MyProperty { get; set; }
    }
}