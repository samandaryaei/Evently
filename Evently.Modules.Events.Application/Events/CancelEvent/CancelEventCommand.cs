using System;
using ICommand = Evently.Modules.Events.Application.Abstractions.Messaging.ICommand;

namespace Evently.Modules.Events.Application.Events.CancelEvent;

public sealed record CancelEventCommand(Guid EventId) : ICommand;
