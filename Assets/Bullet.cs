
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // StartGame is called before the first frame update
    public Vector2 diret;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(diret.normalized*Time.deltaTime);
    }
}
