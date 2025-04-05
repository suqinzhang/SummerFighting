using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class Timer : MonoBehaviour
{
    
    public void _Timer()
    {
        transform.gameObject.SetActive(true);
        StartCoroutine(gc());

    }

    IEnumerator gc()
    {
        yield return new WaitForSeconds(4f);
        transform.gameObject.SetActive(false);
    }
    
     
}
