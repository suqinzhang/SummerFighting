using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.SignalR.Client;
using UnityEngine;
using UnityEngine.UI;
using static Network.Messge;

public class answer_invite : MonoBehaviour
{
    public GameObject item;
    //邀请ui的具体实现
    public void Yes()
    {
        connection.SendAsync("Answer_invite", true,Id_Self,gameObject.GetComponent<Text>().text);
        Destroy(item);
    }

    public void No()
    {
        connection.SendAsync("Answer_invite", false,Id_Self,gameObject.GetComponent<Text>().text);
        Destroy(item);
    }
}
