using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchEffect : MonoBehaviour
{
    private Vector2 direction;
    public float moveSpeed = 0.1f;
    public float effectRangeValue = 1.0f;

    public float minSize = 0.1f;
    public float maxSize = 0.3f;

    public float sizeSpeed = 1.0f;
    // Start is called before the first frame update
    private Image image;

    public Color[] colors;
    public float colorSpeed = 5.0f;
    void Start()
    {
        image = GetComponent<Image>();
        direction = new Vector2(Random.Range(-effectRangeValue, effectRangeValue), 
                                Random.Range(-effectRangeValue, effectRangeValue));
        float size = Random.Range(minSize, maxSize);
        image.color = colors[Random.Range(0,colors.Length)];
        transform.localScale = new Vector3(size, size, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * moveSpeed);
        transform.localScale = Vector2.Lerp(transform.localScale, 
            Vector2.zero, Time.deltaTime * sizeSpeed);

        Color color = image.color;
        color.a = Mathf.Lerp(image.color.a, 0, Time.deltaTime * colorSpeed);
        image.color = color;

        if (image.color.a <= 0.01f)
        {
            Destroy(gameObject);
        }
    }
}
