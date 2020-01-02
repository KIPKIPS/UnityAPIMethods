using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//通过实现接口的方法实现UGUI Event
//Image的Raycast Target必须勾选
//只能监听挂载脚本的GameObject的事件
public class ImageListener : MonoBehaviour, IPointerDownHandler, IPointerClickHandler, IPointerUpHandler,
    IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler,
    IDragHandler, IEndDragHandler, IDropHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
    }

    //public int clickCount=1;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("OnPointClick");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnPointDown "+clickCount+" times");
        Debug.Log("OnPointDown");
        //clickCount++;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OnPointEnter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("OnPointExit");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("OnPointUp");
    }

    void Update() {
        
    }
}
