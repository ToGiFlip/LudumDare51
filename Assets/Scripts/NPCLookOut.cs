using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCLookOut : MonoBehaviour
{
    public float rotSpeed;
    public float minRotAngle;
    public float maxRotAngle;

    public float startTime;
    public float pause;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Interpolate smoothly between 2 values, back and forth
        float rotY = Mathf.SmoothStep(minRotAngle, maxRotAngle, Mathf.PingPong(Time.time * rotSpeed, 1));

        //Aplly interpolation to objects rotation in Y
        transform.rotation = Quaternion.Euler(0, rotY, 0);
    }
}
