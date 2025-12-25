using System.Net;
using System.Net.WebSockets;
using TwitchLib.EventSub.Websockets.Interfaces;

namespace TwitchLib.EventSub.Websockets
{
    /// <summary>
    /// Default implementation of IClientWebsocketProvider
    /// </summary>
    public class DefaultClientWebsocketProvider : IClientWebsocketProvider
    {
        private readonly IWebProxy? _proxy;

        /// <summary>
        /// Create a new instance of DefaultClientWebsocketProvider
        /// </summary>
        /// <param name="proxy">Optional proxy server</param>
        public DefaultClientWebsocketProvider(IWebProxy? proxy = null)
        {
            _proxy = proxy;
        }

        /// <inheritdoc/>
        public ClientWebSocket Create()
        {
            return new ClientWebSocket()
            {
                Options =
                {
                    Proxy = _proxy,
                }
            };
        }
    }
}
