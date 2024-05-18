using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag :MonoBehaviour , IBeginDragHandler, IDragHandler, IEndDragHandler

{
    [HideInInspector] public Transform parentAfterDrag;
    internal Action<Drag> dragEndedCallback;

    public void OnBeginDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        // throw new System.NotImplementedException();
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // throw new System.NotImplementedException();
        transform.SetParent(parentAfterDrag);
    }


}

