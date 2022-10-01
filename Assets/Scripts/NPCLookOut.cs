using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCLookOut : MonoBehaviour
{
    Camera viewCamera;

    // Start is called before the first frame update
    void Start()
    {
        viewCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //Make object look in mouse cursors direction (TEMPORARY)
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        transform.LookAt(mousePos + Vector3.up * transform.position.y);
    }
}
