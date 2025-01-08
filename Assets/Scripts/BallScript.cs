using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // A bool that checks and see if the ball gameobject has changed position or not
    private bool isBallPositionChanged;

    // Start is called before the first frame update
    private void Start()
    {
        // Sets the isBallPositionChanged bool to false
        isBallPositionChanged = false;
    }

    // OnEnable is called when a object is enabled
    private void OnEnable()
    {
        Actions.OnBallEvent += BallTransform;
    }

    // OnDisable is called when a behaviour is disabled
    private void OnDisable()
    {
        Actions.OnBallEvent -= BallTransform;
    }

    // Method that is for changing the position of the ball gameobject
    public void BallTransform()
    {
        // Checks to see if the ball position has changed
            if (isBallPositionChanged == false)
            {
                // Sets the isBallPositionChanged bool to true    
                isBallPositionChanged = true;

                // Changes the ball's position
                transform.position = new Vector3(0, 5, -10);
            }
            else
            {
                // Sets the isBallPositionChanged bool to false
                isBallPositionChanged = false;

                // Resets the ball's position
                transform.position = new Vector3(0, 0.5f, -10);
            }
    }
}
