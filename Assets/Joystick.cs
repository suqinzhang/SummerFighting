using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    public BackGround bk;

    public int speed;

    void Start()
    {
        speed = 20;
    }
    void Update()
    {
        transform.Translate(speed*Time.deltaTime*bk.Horizontal().normalized);
    }
    
}
