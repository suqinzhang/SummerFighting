using Microsoft.AspNetCore.SignalR.Client;
using UnityEngine;
using UnityEngine.UI;
using static Network.Messge;
using static zFramework.Internal.Loom;
namespace Network
{
    public class StartMatch : MonoBehaviour
    {
        public Text Text;
        private string str1 = "正在匹配";
        private string str2 = "开始匹配";
        private bool b { get; set; } = true;
        void match()
        {
            if (b)
            {
                Text.text = str1;
                connection.SendAsync("InMatch");
            }
            else
            {
                Text.text = str2;
                connection.SendAsync("OutMatch");
            }

            b = !b;
        }
    }
}