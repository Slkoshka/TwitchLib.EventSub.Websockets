using TwitchLib.EventSub.Core.SubscriptionTypes.Channel;
using TwitchLib.EventSub.Websockets.Core.EventArgs.Channel;
using TwitchLib.EventSub.Websockets.Core.Models;

namespace TwitchLib.EventSub.Websockets.Handler.Channel.HypeTrains;

internal class ChannelHypeTrainProgressHandlerV2 : NotificationHandler<ChannelHypeTrainProgressV2Args, EventSubNotification<HypeTrainProgressV2>>
{
    public override string SubscriptionType => "channel.hype_train.progress";

    public override string SubscriptionVersion => "2";

    public override string EventName => nameof(EventSubWebsocketClient.ChannelHypeTrainProgressV2);
}
