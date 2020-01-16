using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDemo.Hubs
{
    public class ChannelHub : Hub
    {
        public void AddGroup(string groupName)
        {
            Groups.Add(Context.ConnectionId, groupName);
        }
    }
}