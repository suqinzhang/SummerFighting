
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform trans;
    private Queue<Transform> _queue = new Queue<Transform>();
    public BackGround bk;
    public Transform player;
    // Update is called once per frame
    void Start()
    {
        GameObject Item = new GameObject("Item");
        for (int i = 0; i <= 5; i++)
        {
            Transform tra = Instantiate(trans);
            tra.SetParent(Item.transform);
            tra.gameObject.SetActive(false);
            _queue.Enqueue(tra);
        }
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _shoot();
        }
    }

    void _shoot()
    {
        if (_queue.Count>0)
        {
            
            Transform transf= _queue.Dequeue();
            transf.position = player.position;
            transf.GetComponent<Timer>()._Timer();
            transf.GetComponent<Bullet>().diret = bk.Horizontal();
            StartCoroutine(back(transf));
        }
        
    }

    IEnumerator back(Transform transf)
    {
        yield return new WaitForSeconds(4.1f);
        _queue.Enqueue(transf);
        Debug.Log("Back");
    }
}
