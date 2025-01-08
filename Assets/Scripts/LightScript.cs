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
        Actions.OnLightEvent += LightSwitch;
        isLightOn = true;
    }

    // Update is called once per frame
    private void Update()
    {
        LightSwitch();
    }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {
        Actions.OnLightEvent -= LightSwitch;
    }

    public void LightSwitch()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (isLightOn == true)
            {
                Debug.Log("W is pressed!");
                isLightOn = false;
                gameObject.SetActive(false);
            }
            else
            {
                Debug.Log("W is pressed again!");
                isLightOn = true;
                gameObject.SetActive(true);
            }
        }
    }
}
