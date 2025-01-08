using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokingScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // This is the invoking method that is used for the gameobjects, and activates when you press "Q"
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Invokes the OnBallEvent that's in the ActionsManager script
            Actions.OnBallEvent?.Invoke();

            // Invokes the OnLightEvent that's in the ActionsManager script
            Actions.OnLightEvent?.Invoke();

            // Invokes the OnCapsuleEvent that's in the ActionsManager script
            Actions.OnCapsuleEvent?.Invoke();
        }
    }
}
