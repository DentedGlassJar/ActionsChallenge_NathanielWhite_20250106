using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    // A bool that checks and see if the light gameobject is on or not
    private bool isLightOn;

    // Start is called before the first frame update
    private void Start()
    {
        isLightOn = true;
    }

    private void OnEnable()
    {
        Actions.OnLightEvent += LightSwitch;
    }

    private void OnDisable()
    {
        Actions.OnLightEvent -= LightSwitch;
    }

    public void LightSwitch()
    {
        if (isLightOn == true)
        {
            gameObject.SetActive(false);
            isLightOn = false;
        }
        else
        {
            gameObject.SetActive(true);
            isLightOn = true;
        }
    }
}
