using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehavior : MonoBehaviour
{
    public GameObject staminaBar;

    GameObject playerRef;

    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        UpdateStaminaBar();
    }

    void UpdateStaminaBar(){
        float currentStamina = playerRef.GetComponent<PlayerMovement3D>().stamCurrent;
        float maxStamina = playerRef.GetComponent<PlayerMovement3D>().stamMax;
        staminaBar.GetComponent<Slider>().value = currentStamina / maxStamina;
    }
}
