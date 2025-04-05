
using Microsoft.AspNetCore.SignalR.Client;
using UnityEngine;
using Network;
public class Move : MonoBehaviour
{
    
    // StartGame is called before the first frame update
    void Start()
    {
         Debug.Log(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Messge.connection.SendAsync("ReceiveMsg", "zta");
        }
    }
}
