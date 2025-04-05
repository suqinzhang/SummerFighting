using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace GameRun
{
    
    public class Move : MonoBehaviour
    {
        private Vector2 min_vector { get; set;}
        private Vector2 max_vector { get; set;}

        private void Start()
        {
            min_vector = new Vector2(-700,-400);
            
            max_vector = new Vector2(700, 400);
        }
        private void FixedUpdate()
        {
           
            Vector2 position = transform.position;

            // 限制位置在边界内
            position.x = Mathf.Clamp(position.x, min_vector.x, max_vector.x);
            position.y = Mathf.Clamp(position.y, min_vector.y, max_vector.y);

            // 更新对象的位置
            transform.position = position;
        }
    }
}