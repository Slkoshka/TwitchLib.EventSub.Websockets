using TwitchLib.EventSub.Core.SubscriptionTypes.Channel;
using TwitchLib.EventSub.Websockets.Core.EventArgs.Channel;
using TwitchLib.EventSub.Websockets.Core.Models;

namespace TwitchLib.EventSub.Websockets.Handler.Channel.HypeTrains;

internal class ChannelHypeTrainBeginHandlerV2 : NotificationHandler<ChannelHypeTrainBeginV2Args, EventSubNotification<HypeTrainBeginV2>>
{
    public override string SubscriptionType => "channel.hype_train.begin";

    public override string SubscriptionVersion => "2";

    public override string EventName => nameof(EventSubWebsocketClient.ChannelHypeTrainBeginV2);
}
