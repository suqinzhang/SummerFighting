using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdestroyer : MonoBehaviour
{
    // StartGame is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
