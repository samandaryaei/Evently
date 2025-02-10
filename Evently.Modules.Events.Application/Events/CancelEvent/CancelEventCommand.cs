using System;
using ICommand = Evently.Common.Application.Messaging.ICommand;
using Messaging_ICommand = Evently.Common.Application.Messaging.ICommand;

namespace Evently.Modules.Events.Application.Events.CancelEvent;

public sealed record CancelEventCommand(Guid EventId) : Messaging_ICommand;
