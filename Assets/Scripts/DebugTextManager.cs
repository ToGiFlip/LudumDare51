using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DebugTextManager : MonoBehaviour
{
    // Start is called before the first frame update
    TextMeshProUGUI text;
    GameObject playerRef;
    string[] debugTexts;
    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
        debugTexts = new string[20];
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        debugTexts[0] = "is Running: " + playerRef.GetComponent<PlayerMovement3D>().isSprinting;

        if (debugTexts.Length > 0){
            string debugOutput = string.Join("\n", debugTexts);
            text.text = debugOutput;
        }
    }
}
