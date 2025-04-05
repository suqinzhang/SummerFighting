using Microsoft.AspNetCore.SignalR.Client;
using UnityEngine;
using UnityEngine.UI;
using static Network.Messge;

public class Search_Friend : MonoBehaviour
{
    public InputField Field;
    
    
    public void Seach()
    {
        connection.SendAsync("AddFriend", Field.text,Id_Self);
    }
    
}
