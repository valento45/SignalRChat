using SignalRChat.Services.Interfaces;

namespace SignalRChat.Services
{
    public class HelloWorldService : IHelloWorld
    {
        public Task Print(string username, string message)
        {
            Console.WriteLine($"{username}: {message}");
            return Task.CompletedTask;
        }
    }
}
