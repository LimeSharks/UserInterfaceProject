using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonEvent : MonoBehaviour, IPointerDownHandler
{
    public SceneManger sceneManager;
    public int EnterSceneIndex;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        sceneManager.EnterIndexScene(EnterSceneIndex);
    }
}
