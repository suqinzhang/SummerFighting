using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List_openorclose : MonoBehaviour
{
    public bool Isopen_friend { get; set; } = true;
    public bool isopen_invite { get; set; } = true;
    public bool isopen_apply { get; set; } = true;

    public void OpenOrClose_friend()
    {
        if (Isopen_friend)
        {
            foreach (Transform item in gameObject.transform)
            {
                
                if (item.name=="friend")
                {
                    item.gameObject.SetActive(false);
                }
            }

            Isopen_friend = false;
        }
        else
        {
            foreach (Transform item in gameObject.transform)
            {
                if (item.name=="friend")
                {
                    item.gameObject.SetActive(true);
                }
            }

            Isopen_friend = true;
        }
    }
    
    public void OpenOrClose_invite()
    {
        if (isopen_invite)
        {
            foreach (Transform item in gameObject.transform)
            {
                if (item.name=="invite")
                {
                    item.gameObject.SetActive(false);
                }
            }

            isopen_invite = false;
        }
        else
        {
            foreach (Transform item in gameObject.transform)
            {
                if (item.name=="invite")
                {
                    item.gameObject.SetActive(true);
                }
            }

            isopen_invite = true;
        }
    }
    
    public void OpenOrClose_apply()
    {
        if (isopen_apply)
        {
            foreach (Transform item in gameObject.transform)
            {
                if (item.name=="apply")
                {
                    item.gameObject.SetActive(false);
                }
            }

            isopen_apply = false;
        }
        else
        {
            foreach (Transform item in gameObject.transform)
            {
                if (item.name=="apply")
                {
                    item.gameObject.SetActive(true);
                }
            }

            isopen_apply = true;
        }
    }
}
