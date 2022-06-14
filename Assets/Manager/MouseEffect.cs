using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MouseEffect : MonoBehaviour
{
    public GameObject touchEffect;
    public GameObject touchParents;

    public GameObject createEffect;

    public float spawnsTime;

    public float defaultTime = 0.05f;
    private Vector3 mPosition;
    private Vector3 worldObjectPos;
    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (Input.GetMouseButton(0) && spawnsTime >= defaultTime)
        {
            EffectCreate();
            spawnsTime = 0.0f;
        }

        spawnsTime += Time.deltaTime;
    }

    void EffectCreate()
    {
        mPosition = Input.mousePosition;
        worldObjectPos = Camera.main.ScreenToWorldPoint(mPosition + new Vector3(0,0,10.0f));
        worldObjectPos.z = 0.0f;
        createEffect = Instantiate(touchEffect,worldObjectPos,
            Quaternion.identity);
        createEffect.transform.SetParent(touchParents.transform);
    }
    
}
