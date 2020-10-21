using Chat.Server.Hubs.Interface;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Server.Hubs
{
    public class ChatHub : Hub<IChatHub>
    {

        public async Task SendMessage(string user, string message)
        {
            await Clients.Others.ReciveMessage(user, message);
        }

        public async Task SendUsername(string user)
        {
            await Clients.All.ReciveUsername(user);
        }
    }
}
