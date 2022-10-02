using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Start is called before the first frame update
    Camera cam;
    GameObject playerRef;
    Vector3 desiredPos;

    public float followSpeed = 1f;
    void Start()
    {
        cam = GetComponent<Camera>();    
        playerRef = GameObject.FindGameObjectWithTag("Player");
        GetPlayerPosition();
        UpdateCameraPosition();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetPlayerPosition();
        UpdateCameraPosition();
    }

    void GetPlayerPosition(){
        desiredPos = new Vector3(playerRef.transform.position.x, cam.transform.position.y, playerRef.transform.position.z);
    }

    void UpdateCameraPosition(){
        cam.transform.position = Vector3.Lerp(cam.transform.position, desiredPos, Time.deltaTime * followSpeed);
    }
}
