using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Server.Hubs.Interface
{
    public interface IChatHub
    {
        Task ReciveMessage(string user, string message);
        Task ReciveUsername(string user);
    }
}
