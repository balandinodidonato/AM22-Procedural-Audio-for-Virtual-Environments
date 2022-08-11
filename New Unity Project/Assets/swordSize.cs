using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class swordSize : MonoBehaviour
{
    public Slider swordSlider;

    void Start()
    {
        swordSlider.value = 1;
    }

    public void OnValueChanged(float diameter)
    {
        this.transform.localScale = new Vector3(1, diameter, diameter);
        Debug.Log("Diameter" + diameter);
    }
}
