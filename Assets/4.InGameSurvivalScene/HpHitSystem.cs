using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HpHitSystem : MonoBehaviour
{
    public GameObject hpObject1;
    public GameObject hpObject2;
    public GameObject hpObject3;
    
    public SceneManger sceneManger;
    
    private void Update()
    {
        if (Input.GetKey("p"))
        {
            sceneManger.EnterSuperCupScene();
        }
        else if (Input.GetKey("m"))
        {
            if (hpObject1.activeSelf)
            {
                hpObject1.SetActive(false);
            }
        }
        else if (Input.GetKey("n"))
        {
            if (hpObject2.activeSelf)
            {
                hpObject2.SetActive(false);
            }
        }
        else if (Input.GetKey("b"))
        {
            if (hpObject3.activeSelf)
            {
                hpObject3.SetActive(false);
            }
        }
    }
}
