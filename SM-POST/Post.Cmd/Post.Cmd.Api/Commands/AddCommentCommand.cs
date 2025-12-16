using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

// For adding the comment we need user and his comment
public class AddCommentCommand : BaseCommand
{
    public string UserName { get; set; }

    public string Comment { get; set; }
}