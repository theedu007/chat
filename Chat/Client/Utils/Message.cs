using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Client.Utils
{
    public class Message
    {
        public string User { get; set; }
        public string Content { get; set; }
        public MessageType MessageType { get; set; }
    }
}
