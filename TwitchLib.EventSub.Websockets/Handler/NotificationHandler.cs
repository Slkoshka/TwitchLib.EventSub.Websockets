using System;
using System.Text.Json;
using TwitchLib.EventSub.Websockets.Core.EventArgs;
using TwitchLib.EventSub.Websockets.Core.Handler;

namespace TwitchLib.EventSub.Websockets.Handler;


// internal so we can change it without breaking changes in the future
internal abstract class NotificationHandler<TEvent, TModel> : INotificationHandler
    where TEvent : TwitchLibEventSubEventArgs<TModel>, new()
    where TModel : new()
{
    /// <inheritdoc />
    public abstract string SubscriptionType { get; }

    /// <inheritdoc />
    public abstract string SubscriptionVersion { get; }

    /// <inheritdoc />
    public abstract string EventName { get; }

    /// <inheritdoc />
    public void Handle(EventSubWebsocketClient client, string jsonString, JsonSerializerOptions serializerOptions)
    {
#pragma warning disable CA1031 // Do not catch general exception types
        try
        {
            var data = JsonSerializer.Deserialize<TModel>(jsonString, serializerOptions);

            if (data is null)
                throw new InvalidOperationException("Parsed JSON cannot be null!");

            client.RaiseEvent(EventName, new TEvent { Notification = data });
        }
        catch (Exception ex)
        {
            // TODO events are async, so we NEVER get here
            // possible solutions:
            // rewriting RaiseEvent to return: 'Task?' and await if not null
            client.RaiseEvent(nameof(EventSubWebsocketClient.ErrorOccurred), new ErrorOccuredArgs { Exception = ex, Message = $"Error encountered while trying to handle {SubscriptionType}/{SubscriptionVersion} notification! Raw Json: {jsonString}" });
        }
#pragma warning restore CA1031 // Do not catch general exception types
    }
}
