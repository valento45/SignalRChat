using Microsoft.AspNetCore.SignalR;
using SignalRChat.Services.Interfaces;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IHelloWorld _helloWorld;

        public ChatHub(IHelloWorld helloWorld)
        {
            _helloWorld = helloWorld;
        }


        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            await _helloWorld.Print(user, message);
        }
    }
}
