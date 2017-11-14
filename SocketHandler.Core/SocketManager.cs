using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks; 
using SocketHandler.Core.SocketModels;
using SocketHandler.Core.Interfaces;

namespace SocketHandler.Core
{
    public class SocketManager : ISocketManager
    {
        public SocketManager()
        {
        }

        public async void AddSocket(WebSocket socket)
        {
            throw new NotImplementedException();
        }

        public async void AddToGroup(string socketID, string groupID)
        {
            throw new NotImplementedException();
        }

        public string CreateConnectionId()
        {
            throw new NotImplementedException();
        }

        public List<Connection> CurrentConnections()
        {
            throw new NotImplementedException();
        }

        public  List<string> GetAllFromGroup(string GroupID)
        {
            throw new NotImplementedException();
        }

        public string GetId(WebSocket socket)
        {
            throw new NotImplementedException();
        }

        public WebSocket GetSocketById(string id)
        {
            throw new NotImplementedException();
        }

        public async void RemoveFromGroup(string socketID, string groupID)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveSocket(string id)
        {
            throw new NotImplementedException();
        }
    }
}