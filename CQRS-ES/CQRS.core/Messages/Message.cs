using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.core.Messages
{
    public abstract class Message
    {
        public Guid Id { get; set; }   
    }
}