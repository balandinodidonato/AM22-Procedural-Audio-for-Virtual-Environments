using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Animation : MonoBehaviour
{
    Animator m_Animator;
    float attackSpeed = 1.0f;
    bool isAttacking = false;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(5, 50, 100, 50), "Speed");
        attackSpeed = GUI.HorizontalSlider(new Rect(50, 55, 200, 50), attackSpeed, 0.0F, 2.0F);
        GUI.Label(new Rect(270, 50, 200, 50), attackSpeed.ToString());

        m_Animator.speed = attackSpeed;
    }

    public void OnValueChanged(float value)
    {
        Debug.Log(value);
    }

        // Update is called once per frame
        void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            m_Animator.SetTrigger("idleT");
            isAttacking = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            m_Animator.SetTrigger("attackT");
            isAttacking = true;
        }

        if (isAttacking)
        {
            float normTime = m_Animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
            int loopTimes = (int)normTime;
            float swingTime = normTime - loopTimes;
            bool swing0, swing1;


            if (swingTime > 0 && swingTime < 0.35)
            {
                swing0 = true;
            }
            else
            {
                swing0 = false;
            }

            if (swingTime > 0.35 && swingTime < 0.55)
            {
                swing1 = true;
            }
            else
            {
                swing1 = false;
            }

            Debug.Log("swing0: " + swing0);
            Debug.Log("swing1: " + swing1);
        }
    }
}