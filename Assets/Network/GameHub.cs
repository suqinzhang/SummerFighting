
using System;
using UnityEngine;
using static Network.Messge;
namespace Network
{
    public class GameHub : MonoBehaviour
    {
        
             //注销client
             private void OnDestroy()
             {
                 
                    if (connection != null)
                    {  
                        connection.DisposeAsync();
                        
                    }
                 
             }
             
        }
    }
    