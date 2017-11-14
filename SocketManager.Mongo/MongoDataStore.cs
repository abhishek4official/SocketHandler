using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Threading.Tasks;
using MongoDB.Driver;
using SocketHandler.Core.Interfaces;
using SocketHandler.Core.SocketModels;

namespace SocketManager.Mongo {
    public class MongoDataStore : ISocketManager {
        private MongoClient mongoClient { get; set; }
        private IMongoDatabase mongoCollection {get;set;}

        private IMongoCollection<SocketClients> collection{get;set;}
        public MongoDataStore (string MongoDBConnectionString) {


            // or use a connection string
            mongoClient = new MongoClient (MongoDBConnectionString);
            mongoCollection=mongoClient.GetDatabase("SocketHandler");
            collection = mongoCollection.GetCollection<SocketHandlerClients>("Clients");

        }
        public async void AddSocket (WebSocket socket) {
            SocketClients client=new SocketClients(){
                ConnectionID=CreateConnectionId();
                socket=socket;
            };
            collection.InsertOne(client);
        }

        public async void AddToGroup (string ConnectionID, string groupID) {
            
        }

        private string CreateConnectionId () {
            return Guid.NewGuid().ToString();
        }

        public List<Connection> CurrentConnections () {
            throw new System.NotImplementedException ();
        }

        public List<string> GetAllFromGroup (string GroupID) {
            throw new System.NotImplementedException ();
        }

        public string GetId (WebSocket socket) {
            throw new System.NotImplementedException ();
        }

        public WebSocket GetSocketById (string id) {
            throw new System.NotImplementedException ();
        }

        public async void RemoveFromGroup (string socketID, string groupID) {
            throw new System.NotImplementedException ();
        }

        public async Task RemoveSocket (string id) {
            throw new System.NotImplementedException ();
        }
    }
    class SocketClients {
        public string ConnectionID{get;set;}
        public WebSocket socket{get;set;}
    }
    class SocketGroups{
        public string ConnectionID{get;set;}
        public string GroupID {get;set;}
    }
}