using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

// For editing an existing message post
public class EditMessageCommand : BaseCommand
{
    public string Message { get; set; }
}