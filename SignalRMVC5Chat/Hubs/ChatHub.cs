using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRMVC5Chat
{
    public class ChatHub : Hub
    {
        static int _connectionCounter =0;

        public void Hello()
        {
            Clients.All.hello();
            
        }

        public void recordHit()
        {
            _connectionCounter += 1;
            Clients.All.showCounter(_connectionCounter);
        }

        public void Send(string name, string message)
        {
            
            Clients.All.addNewMessageToPage(name, message);
        }

        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            _connectionCounter -= 1;
            Clients.All.showCounter(_connectionCounter);
            return base.OnDisconnected(stopCalled);
        }
    }
}