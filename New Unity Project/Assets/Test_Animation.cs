using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_Animation : MonoBehaviour
{
    Animator m_Animator;
    public Slider speedSlider;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
        speedSlider.value = 1;
    }

    public void OnValueChanged(float value)
    {   
        m_Animator.speed = value;
        Debug.Log(speedSlider.value);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            m_Animator.SetTrigger("idleT");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            m_Animator.SetTrigger("attackT");
        }
    }
}