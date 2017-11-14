using System.Net.WebSockets;

namespace SocketHandler.Core.SocketModels {
    public class Connection {
        public string ConnectionID { get; set; }
        public WebSocket websocket { get; set; }
    }
}