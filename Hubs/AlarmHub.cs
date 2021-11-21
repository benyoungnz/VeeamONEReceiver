using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace VeeamONEReceiver.Hubs
{
    public class AlarmHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}