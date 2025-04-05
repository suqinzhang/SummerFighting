using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeUi : MonoBehaviour
{
    void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();

        if (rectTransform != null)
        {
            // 将锚点设置为左下角(0,0) 和 右上角(1,1)
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = new Vector2(0.5f,1);

            // 偏移量设置为0
            rectTransform.offsetMin = Vector2.zero;
            rectTransform.offsetMax = Vector2.zero;
        }
    }
}
