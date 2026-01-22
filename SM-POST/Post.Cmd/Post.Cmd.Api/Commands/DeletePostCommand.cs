using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

// We need the username of the person who created the social media post should be able to delete.
public class DeletePostCommand : BaseCommand
{
    public string UserName { get; set; }
}