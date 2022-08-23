using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_Animation : MonoBehaviour
{
    Animator m_Animator;
    public Slider speedSlider;
    GameObject footTracker;
    float footTrackerY;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
        speedSlider.value = 1;
        footTracker = GameObject.Find("FootTracker");
    }

    public void OnValueChanged(float value)
    {   
        m_Animator.speed = value;
        Debug.Log(speedSlider.value);
    }

    // Update is called once per frame
    void Update()
    {
        //footTrackerY = footTracker.transform.position.y;
        //transform.position = transform.position - new Vector3(0, footTrackerY, 0);

        if (Input.GetKey(KeyCode.I))
        {
            m_Animator.SetTrigger("idleT");
            transform.position = new Vector3(0, 0, 0);
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            m_Animator.SetTrigger("attackT");
            transform.position = new Vector3(0, 0, 0);
           /// footTrackerPosition = footTracker.transform.position;
        }
    }
}