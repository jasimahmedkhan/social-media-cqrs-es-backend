using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

// For creating a new Post message requires Author and its Message
public class NewPostCommand : BaseCommand
{
    public string Author { get; set; }

    public string Message { get; set; }
}