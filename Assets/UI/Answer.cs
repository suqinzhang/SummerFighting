using Microsoft.AspNetCore.SignalR.Client;
using UnityEngine;
using UnityEngine.UI;
using static Network.Messge;
public class Answer : MonoBehaviour
{
    public GameObject item;
    public void Yes()
    {
        connection.SendAsync("Answer", true,Id_Self,gameObject.GetComponent<Text>().text);
        Destroy(item);
    }

    public void No()
    {
        connection.SendAsync("Answer", false,Id_Self,gameObject.GetComponent<Text>().text);
        Destroy(item);
    }
}
