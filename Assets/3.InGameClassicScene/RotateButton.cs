using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateButton : MonoBehaviour, IPointerDownHandler
{

    public GameController gameController;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        gameController.OnRotateButtonTap();
    }
}