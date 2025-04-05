 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Friend_list : MonoBehaviour
{
    public GameObject Item_prefeb;
    public RectTransform compent;

    private List<GameObject> items = new List<GameObject>();
    // StartGame is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
                    GameObject item = Instantiate(Item_prefeb,compent);
                    Text itemText =  item.GetComponentInChildren<Text>();
                    itemText.text = $"zta{i}";
                    items.Add(item);
        }
    }
    
    
}
