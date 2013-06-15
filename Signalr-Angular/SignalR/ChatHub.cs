using Microsoft.AspNet.SignalR;
using Signalr_Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Signalr_Angular.SignalR
{
    public class ChatHub : Hub
    {
        public void Send(string message)
        {
            ChatModel.OnRaiseChatMessage += RaiseChatMessageHandler;
            ChatModel.StartChatCommunications();
        }

        public void RaiseChatMessageHandler(string message)
        {
            Clients.Caller.Receive(message);
        }
    }
}