using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

// For this we need to identify the comment id for the comment and the comment content and the username who has added the comment.
public class EditCommentCommand : BaseCommand
{
    public Guid CommentId { get; set; }
    public string Comment { get; set; }
    public string UserName { get; set; }
}