using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class AddCommentCommand : BaseCommand
    {
        public string Comment { get; set; } = null!;
        public string Username { get; set; } = null!;
    }
}