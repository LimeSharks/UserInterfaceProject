using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class CountDown : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    
    public GameObject tarGameObject;
    public GameObject tarGameObject2;
    public GameObject tarGameObject3;
    public GameObject tarGameObject4;

    public int count;
    
    public float countTimer;
    public float defaultTimer = 1.0f;
    
    public GameObject startingGameObject;
    public GameObject countGameObject;

    public SceneManger sceneManger;
    
    // Start is called before the first frame update
    void Start()
    {
        count = 10;
        textMesh.text = $"{count}";
    }

    // Update is called once per frame
    void Update()
    {
        if (tarGameObject.activeSelf && tarGameObject2.activeSelf && tarGameObject3.activeSelf &&
            tarGameObject4.activeSelf)
        {
            startingGameObject.SetActive(true);
            countGameObject.SetActive(true);
        }
        else
        {
            startingGameObject.SetActive(false);
            countGameObject.SetActive(false);
        }

        if (startingGameObject.activeSelf && countGameObject.activeSelf)
        {
            countTimer += Time.deltaTime;
            if (countTimer >= defaultTimer)
            {
                count--;
                countTimer = 0.0f;
            }

            textMesh.text = $"{count}";
            if (count == 0)
            {
                sceneManger.EnterButtonClassicScene();
            }
        }
        else
        {
            count = 10;
        }
    }
}
