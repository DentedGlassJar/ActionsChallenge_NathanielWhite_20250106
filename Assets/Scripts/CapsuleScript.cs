using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour
{
    // A bool that checks and see if the capsule gameobject has changed scale or not
    private bool isCapsuleScaleChanged;

    // Start is called before the first frame update
    private void Start()
    {
        isCapsuleScaleChanged = false;
    }

    // OnEnable is called when a object is enabled
    private void OnEnable()
    {
        Actions.OnBallEvent += CapsuleTransform;
    }

    // OnDisable is called when a behaviour is disabled
    private void OnDisable()
    {
        Actions.OnBallEvent -= CapsuleTransform;
    }

    // Method that is for changing the scale of the capsule gameobject
    public void CapsuleTransform()
    {
        // Checks to see if the ball position has changed
        if (isCapsuleScaleChanged == false)
        {
            // Changes the capsule's scale
            gameObject.transform.localScale = new Vector3(3, 3, 3);

            // Sets the isBallPositionChanged bool to true
            isCapsuleScaleChanged = true;
        }
        else
        {
            // Resets the capsule's scale
            gameObject.transform.localScale = new Vector3(1, 1, 1);

            // Sets the isCapsuleScaleChanged bool to false
            isCapsuleScaleChanged = false;
        }
    }
}
