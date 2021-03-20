using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverImpl
{
    internal class Message
    {
        private string messageContent;

        public Message(string messageContent)
        {
            this.messageContent = messageContent;
        }

        public string GetMessageContent()
        {
            return messageContent;
        }
    }
}