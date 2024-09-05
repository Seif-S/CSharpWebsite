using Microsoft.AspNetCore.SignalR;

namespace WebBlazorApp.ChatHub
{
    public class Chat : Hub
    {
        public async Task SendData(string username, string Post) => await Clients.All.SendAsync("RecievedPost", username, Post);
    }
}
