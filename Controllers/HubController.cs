using Microsoft.AspNet.SignalR;
using SignalRDemo.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRDemo.Controllers
{
    public class HubController : Controller
    {
        private readonly static IHubContext hub = GlobalHost.ConnectionManager.GetHubContext<ChannelHub>();
        // GET: Hub
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Send(string groupName, string message)
        {
            hub.Clients.Group(groupName).showmessage(message);

            return View("Index");
        }
    }
}