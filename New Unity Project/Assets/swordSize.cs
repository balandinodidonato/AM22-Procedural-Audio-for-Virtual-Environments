using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class swordSize : MonoBehaviour
{
    Transform sword;
    public Slider swordSlider;

    void Start()
    {
        sword = GetComponent<Transform>();
        swordSlider.value = 1;
    }

    public void OnValueChanged(float value)
    {
        Vector3 size = new Vector3(1, value, value);
        sword.localScale = size;
    }
}
