using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Signalr_Angular.Models
{
    public class ChatModel
    {
        public delegate void ChatMessageEventHandler(string message);
        public static ChatMessageEventHandler OnRaiseChatMessage;

        public static void StartChatCommunications()
        {
            if(OnRaiseChatMessage != null)
            {
                for (int i = 0; i < 100; i++)
                {
                    OnRaiseChatMessage(Guid.NewGuid().ToString());
                }
            }
        }
    }
}