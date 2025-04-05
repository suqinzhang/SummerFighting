
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http.Connections.Client;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;


namespace Network
{
    public static class Messge 
    {
        public static HubConnection connection;
        public static string Id_Self { get; set; }
        public static string _myAccessToken { get; set; }
        static Messge()
        {

            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5130/Gamehub", options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(_myAccessToken);
                })
                .Build();
        }

    }
}