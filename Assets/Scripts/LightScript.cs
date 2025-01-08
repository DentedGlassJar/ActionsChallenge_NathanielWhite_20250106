using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    private void OnEnable()
    {
        Actions.OnLightEvent += LightSwitch;
    }
    private void OnDisable()
    {
        Actions.OnLightEvent += LightSwitch;
    }

    public void LightSwitch()
    {

    }
}
