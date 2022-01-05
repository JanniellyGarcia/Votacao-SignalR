using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRVotacao.Hubs
{
    public class PollHub : Hub
    {
        //Método SendMessage é responsável por mandar as mensagens (Votação) em real-time (Tempo real) para todos que estiverem na conexão.
        public async Task SendMessage(string user, string message, string myChannelId, string myChannelVal)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, myChannelId, myChannelVal).ConfigureAwait(false);
        }
    }
}
