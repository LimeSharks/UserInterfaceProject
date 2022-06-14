using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmenyCameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveCamera()
    {
        
        Vector3 targePos = new Vector3( gameObject.transform.position.x - 421.0f, gameObject.transform.position.y, gameObject.transform.position.z);
        transform.position = Vector3.Lerp(gameObject.transform.position,targePos,0.1f);
    }
    
}
