using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class DeletePostCommand : BaseCommand
    {
        public string Username { get; set; } = null!;
    }
}