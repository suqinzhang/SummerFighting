using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using UnityEngine;
using UnityEngine.UI;
using static zFramework.Internal.Loom;
using static Network.Messge;

public class Receive_invite : MonoBehaviour
{
    public GameObject invite_prefab;
    public RectTransform compent;
    public GameObject target1;
    void Start()
    {
        connection.On<string>("ReceiveInvite",   ReceiveInvite);
    }

    //只是加载邀请ui到列表里，具体相应没有。
    public async Task ReceiveInvite(string id_op)
    {
        await ToMainThread;
        GameObject item = Instantiate(invite_prefab,compent);
        item.name = "invite";
        int targetIndex = target1.transform.GetSiblingIndex();
        item.transform.SetSiblingIndex(targetIndex+1);
        Text itemText =  item.transform.Find("item").GetComponent<Text>();
        itemText.text = $"{id_op}";
        
    }
    
}
