using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using UnityEngine;
using static Network.Messge;
using static zFramework.Internal.Loom;
namespace Network
{
    public class StartGame : MonoBehaviour
    {
        public class GroupContext
        {
            public IPAddress[] IpAddresses { get; set; }
            public int[] Actors { get; set; }
            public int[] Skins { get; set; }
        }
        private void Start()
        {
            connection.On<GroupContext>("StartG", StartG);
        }

        private async Task StartG(GroupContext ctx)
        {
            
        }
    }
}
