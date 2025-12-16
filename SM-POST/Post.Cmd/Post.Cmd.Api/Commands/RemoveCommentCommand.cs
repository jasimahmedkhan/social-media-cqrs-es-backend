using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

// For remove comment we need comment id of the comment we need to delete and the username of the user who
// wants its comment to be deleted and making sure only the correct user i.e. who have added the comment
// should be able to delete the comment.
public class RemoveCommentCommand : BaseCommand
{
    public Guid CommentId { get; set; }

    public string UserName { get; set; }
}