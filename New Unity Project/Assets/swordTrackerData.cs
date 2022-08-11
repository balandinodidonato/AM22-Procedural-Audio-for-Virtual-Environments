using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordTrackerData : MonoBehaviour
{
    Vector3 previousPosition;
    Vector3 currentPosition;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = this.transform.position;

        if (currentPosition != previousPosition)
        {
            float speed = (currentPosition - previousPosition).magnitude / Time.deltaTime;
            Debug.Log("Speed: " + speed);
        }

        previousPosition = transform.position;
    }
}
