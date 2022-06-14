using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonFalseEvent : MonoBehaviour, IPointerDownHandler
{
    
    public GameObject tarGameObject;
    public GameObject tarGameObject2;
    public GameObject tarGameObject3;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        tarGameObject.SetActive(false);
        tarGameObject2.SetActive(false);
        tarGameObject3.SetActive(false);
    }
}
