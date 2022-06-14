using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    
    public GameObject tarGameObjectReady2;
    public GameObject tarGameObjectGo2;
    
    public GameObject tarGameObjectReady3;
    public GameObject tarGameObjectGo3;
    
    public GameObject tarGameObjectReady4;
    public GameObject tarGameObjectGo4;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("2"))
        {
            tarGameObjectReady2.SetActive(true);
            tarGameObjectGo2.SetActive(true);
        }

        if (Input.GetKey("3"))
        {
            tarGameObjectReady3.SetActive(true);
            tarGameObjectGo3.SetActive(true);
        }
        
        
        if (Input.GetKey("4"))
        {
            tarGameObjectReady4.SetActive(true);
            tarGameObjectGo4.SetActive(true);
        }
    }
}
