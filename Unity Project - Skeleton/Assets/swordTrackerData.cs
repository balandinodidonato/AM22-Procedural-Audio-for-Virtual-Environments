using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordTrackerData : MonoBehaviour
{
    Vector3 previousPosition;
    Vector3 currentPosition;
    float speedRaw;

    public LibPdInstance pdPatch;

    // Start is called before the first frame update
    void Start()
    {
        currentPosition = transform.position; // initialises the current position
        speedRaw = 0; // initialises the initial raw speed
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position; // stores the current position

        speedRaw = (currentPosition - previousPosition).magnitude / Time.deltaTime; // calculates the difference of the sword position between frames
        pdPatch.SendFloat("speedUnity", speedRaw); // sends the speed value to the Pure Data patch

        previousPosition = transform.position; // stores the value of the current position to be used as previous position the next time the Update function is called
    }
}
