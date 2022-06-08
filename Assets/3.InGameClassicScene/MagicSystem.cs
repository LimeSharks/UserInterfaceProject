using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MagicSystem : MonoBehaviour
{
    public GameObject whiteMagic;

    public GameObject blackMagic;

    public SceneManger sceneManger;
    public float whiteSpawnsTime;
    public float blackSpawnsTime;
    public float defaultTime = 1.0f;
    // Update is called once per frame
    private void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey("k") && Input.GetKey("K"))
        {
            sceneManger.EnterSuperCupScene();
        }
    
        if (!whiteMagic.activeSelf)
        {
            whiteSpawnsTime += Time.deltaTime;
            if (whiteSpawnsTime >= defaultTime)
            {
                whiteMagic.SetActive(true);
                whiteSpawnsTime = 0.0f;
            }
        }
        if (!blackMagic.activeSelf)
        {
            blackSpawnsTime += Time.deltaTime;
            
            if (blackSpawnsTime >= defaultTime)
            {
                blackMagic.SetActive(true);
                blackSpawnsTime = 0.0f;
            }
        }
    }
}
