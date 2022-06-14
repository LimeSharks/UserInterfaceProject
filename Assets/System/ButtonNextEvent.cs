using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonNextEvent : MonoBehaviour, IPointerDownHandler
{
    public GameObject tarGameObject;
    public GameObject tarGameObject2;
    public GameObject tarGameObject3;
    
    
    public void OnPointerDown(PointerEventData eventData)
    {
        tarGameObject.SetActive(true);
        tarGameObject2.SetActive(true);
        tarGameObject3.SetActive(true);
    }
}
