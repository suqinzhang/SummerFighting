using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public Vector2 position{get;set;}
    public Vector2 velocity{get;set;}
    public readonly int cooltime = 4;
    public  bool iscool{get;set;}
    public Action skill{get;set;}
    
}
