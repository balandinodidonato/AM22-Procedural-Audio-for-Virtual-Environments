using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordTrackerData : MonoBehaviour
{
    Vector3 previousPosition;
    Vector3 currentPosition;
    float speedScaleFactor = 300;
    float maxSpeed = 40;
    float speedRaw = 0;

    public LibPdInstance pdPatch;

    // Start is called before the first frame update
    void Start()
    {
        currentPosition = transform.position;
        speedRaw = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position;

        speedRaw = (currentPosition - previousPosition).magnitude / Time.deltaTime;
        pdPatch.SendFloat("speedUnity", speedRaw);

        previousPosition = transform.position;
    }
}
