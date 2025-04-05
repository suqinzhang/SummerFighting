using UnityEngine;
using UnityEngine.EventSystems;


public class BackGround : MonoBehaviour, IDragHandler,  IEndDragHandler
{
    
    public RectTransform rectTransform;
    
    public RectTransform rectTransform1;
    
    // 拖动时调用
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 localposition;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform1,eventData.position,eventData.pressEventCamera,out localposition))
        {
            localposition = Vector2.ClampMagnitude(localposition, 80f);
            rectTransform.anchoredPosition = localposition;
             
        }
    }

    // 结束拖动时调用
    public void OnEndDrag(PointerEventData eventData)
    {
        // 拖动结束时，将位置重置为原点
        rectTransform.anchoredPosition = Vector2.zero;
      
    }
    public Vector2 Horizontal()
    {
        return rectTransform.anchoredPosition;
    }
}