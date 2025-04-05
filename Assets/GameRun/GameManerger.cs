using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManerger : MonoBehaviour
{
    public GameObject  prefab_bullet;
    public static List<GameObject> stones = new ();
    public static Queue<GameObject> Bullet_Pool = new();
    public static Queue<GameObject> bullets_Out = new ();
    public static Queue<int> numbers = new();
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
           Bullet_Pool.Enqueue(Instantiate(prefab_bullet));
        }
        
    }
    
    void FixedUpdate()
    {
        
    }
    /// <summary>
    /// 判断物体碰撞，
    /// </summary>
    void Update()
    {
        
    }
}
