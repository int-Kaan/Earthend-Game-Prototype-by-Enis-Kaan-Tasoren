using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEditor;

public class MoveAblePanel : MonoBehaviour, IDragHandler
{
    [SerializeField] private RectTransform dragRectTransform;
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging !");
        dragRectTransform.anchoredPosition += eventData.delta;
    }
}
