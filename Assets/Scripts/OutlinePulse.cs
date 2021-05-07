using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutlinePulse : MonoBehaviour
{
    [SerializeField] float alfa;
    [SerializeField] private Outline textOutline;

    private float minimum = 0.0f;
    private float maximum = 1.0f;
    float t = 0.0f;

    private void Update()
    {
        alfa = Mathf.Lerp(minimum, maximum, t);
        t += 1.5f * Time.deltaTime;
        if (t > 1.0f)
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
        }
        textOutline.effectColor = new Color(0f, 0f, 0f, alfa);
    }
}
