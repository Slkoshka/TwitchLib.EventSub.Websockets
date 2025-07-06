using TwitchLib.EventSub.Core.SubscriptionTypes.Channel;
using TwitchLib.EventSub.Websockets.Core.EventArgs.Channel;
using TwitchLib.EventSub.Websockets.Core.Models;

namespace TwitchLib.EventSub.Websockets.Handler.Channel.HypeTrains;

internal class ChannelHypeTrainEndHandlerV2 : NotificationHandler<ChannelHypeTrainEndV2Args, EventSubNotification<HypeTrainEndV2>>
{
    public override string SubscriptionType => "channel.hype_train.end";

    public override string SubscriptionVersion => "2";

    public override string EventName => nameof(EventSubWebsocketClient.ChannelHypeTrainEndV2);
}
