using System.Net.WebSockets;

namespace TwitchLib.EventSub.Websockets.Interfaces
{
    /// <summary>
    /// Provider for ClientWebSocket instances
    /// </summary>
    public interface IClientWebsocketProvider
    {
        /// <summary>
        /// Creates a new instance of ClientWebSocket
        /// </summary>
        /// <returns>A new instance of ClientWebSocket</returns>
        ClientWebSocket Create();
    }
}
