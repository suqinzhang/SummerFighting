
using Microsoft.AspNetCore.SignalR.Client;
using UnityEngine;
using static Network.Messge;
public class Invite_Friend : MonoBehaviour
{
    public string Id { get; set; }
    
    public void Invite()
    {
        connection.SendAsync("Invite_Team", Id_Self,Id);
    }
    
    
    
}
