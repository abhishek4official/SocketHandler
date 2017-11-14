using System.Collections.Generic;
using System.Net.WebSockets;
using System.Threading.Tasks;
using SocketHandler.Core.SocketModels;

namespace SocketHandler.Core.Interfaces
{
    public interface ISocketManager
    {
        Task RemoveSocket(string id);
        void RemoveFromGroup(string ConnectionID, string groupID);
        void AddToGroup(string ConnectionID, string groupID);
        void AddSocket(WebSocket socket);
        string GetId(WebSocket socket);
        List<string> GetAllFromGroup(string GroupID);
        List<Connection> CurrentConnections ();
        WebSocket GetSocketById(string id);
    }
}