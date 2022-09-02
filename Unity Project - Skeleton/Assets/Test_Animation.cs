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
        speedSlider.value = 1; // initialises slider value
    }

    public void OnValueChanged(float value)
    {   
        m_Animator.speed = value; // changes the animation speed when acting on the speed slider
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I)) // the condition is True when when the 'i' key is released 
        {
            m_Animator.SetTrigger("idleT"); // triggers idle position
            transform.position = new Vector3(0, 0, 0); // resets origin
        }

        if (Input.GetKey(KeyCode.A)) // the condition is True when when the 'a' key is released 
        {
            transform.position = new Vector3(0, 0, 0); // resets origin
            m_Animator.SetTrigger("attackT"); // triggers attack animation
        }
    }
}