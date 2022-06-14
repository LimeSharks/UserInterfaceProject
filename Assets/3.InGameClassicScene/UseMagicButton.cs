using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UseMagicButton : MonoBehaviour, IPointerDownHandler
{
    public GameObject tarGameObject;
    
    public AudioSource audioSource;

    public AudioClip audioClip;

    public EmenyCameraMove emenyCameraMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        
        if (audioSource != null && audioClip != null)
        {
            audioSource.PlayOneShot(audioClip);
        }

        if (tarGameObject.name == "BlackButton")
        {
            emenyCameraMove.MoveCamera();
        }

        tarGameObject.SetActive(false);
        
    }
}
