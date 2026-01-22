using CQRS.Core.Messages;

namespace CQRS.Core.Commands;

// Note: we need each command object to have a ID field.
// Each command type has a message enclosed in it which describes the metadata for a command.
// Setting base command to abstract as there can be many different types of command,
// but the underlying properties would remain same.
public abstract class BaseCommand : Message
{
}