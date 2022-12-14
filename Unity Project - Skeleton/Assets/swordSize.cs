using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class swordSize : MonoBehaviour
{
    public Slider swordSlider;

    float scaleFactor;

    void Start()
    {
        // initialise the sword slider
        swordSlider.minValue = 0.0001f;
        swordSlider.maxValue = 0.03f;
        swordSlider.value = 0.02f;
        scaleFactor = 1.5f / swordSlider.maxValue;
        transform.localScale = new Vector3(1, swordSlider.value * scaleFactor, swordSlider.value * scaleFactor);
    }

    public void OnValueChanged(float diameter)
    {
        transform.localScale = new Vector3(1, diameter * scaleFactor, diameter * scaleFactor); // scales the y and w dimensions of the sword
    }
}
