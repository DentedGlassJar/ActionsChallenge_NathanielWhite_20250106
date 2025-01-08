using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    // A bool that checks and see if the light gameobject is on or not
    private bool isLightOn;

    // A Light variable that controls the light gameobject
    Light lightObject;

    // Start is called before the first frame update
    private void Start()
    {
        // Makes the lightObject variable the light gameobject itself
        lightObject = GetComponent<Light>();

        // Sets isLightOn to true
        isLightOn = true;
    }

    // OnEnable is called when a object is enabled
    private void OnEnable()
    {
        Actions.OnLightEvent += LightSwitch;
    }

    // OnDisable is called when a behaviour is disabled
    private void OnDisable()
    {
        Actions.OnLightEvent -= LightSwitch;
    }

    // Method that is for changing the intensity of the light gameobject
    public void LightSwitch()
    {
        // Checks to see if the light is on or not
        if (isLightOn == true)
        {
            // Turns the light's intensity to 0
            lightObject.intensity = 0f;

            // Sets isLightOn to false
            isLightOn = false;
        }
        else
        {
            // Turns the light's intensity to 2 
            lightObject.intensity = 2f;

            // Sets isLightOn to true
            isLightOn = true;
        }
    }
}
