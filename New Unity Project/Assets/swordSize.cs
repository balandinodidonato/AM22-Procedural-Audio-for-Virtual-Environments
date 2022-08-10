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

    void Update()
    {
        Vector3 size = new Vector3(swordSlider.value , swordSlider.value , swordSlider.value );
        sword.localScale = size;
    }
}
