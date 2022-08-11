using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordTrackerData : MonoBehaviour
{
    Vector3 previousPosition;
    Vector3 currentPosition;
    float speedScaleFactor = 300;
    float maxSpeed = 40;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position;

        if (currentPosition != previousPosition)
        {
            float speed = (currentPosition - previousPosition).magnitude / Time.deltaTime;

            float scaledSpeed = (speed / speedScaleFactor) * maxSpeed;

            if (scaledSpeed > maxSpeed)
            {
                speedScaleFactor = speed;
                Debug.Log("speedScaleFactor: " + speedScaleFactor);
            }

            // Here send is where scaled speed is sent to Pd

        }

        previousPosition = transform.position;


    }
}
