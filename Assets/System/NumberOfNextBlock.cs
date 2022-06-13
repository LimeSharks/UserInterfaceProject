using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberOfNextBlock : MonoBehaviour
{
    public TextMeshProUGUI textMesh;

    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 15;
        textMesh.text = $"{count}";
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = $"{count}";
    }
}
