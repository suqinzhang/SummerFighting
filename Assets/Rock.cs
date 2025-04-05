using System.Collections;
 
using UnityEngine;

public class Rock : MonoBehaviour
{
    public Transform rock;
    // StartGame is called before the first frame update
    void Start()
    {
        rock.gameObject.SetActive(false);
        StartCoroutine(flash());
    }

    IEnumerator flash()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            int x = Random.Range(-130, 100);
            int y = Random.Range(-40, 50);
            rock.position =new Vector2(x, y);
            rock.gameObject.SetActive(true);
            yield return new WaitForSeconds(3f);
            rock.gameObject.SetActive(false);
        }
    }
     
    
}
