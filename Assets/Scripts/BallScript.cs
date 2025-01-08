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
        isBallPositionChanged = false;
    }

    // Update is called once per frame
    private void Update()
    {
        BallTransform();
    }

    private void OnEnable()
    {
        Actions.OnBallEvent += BallTransform;  
    }

    private void OnDisable()
    {
        Actions.OnBallEvent -= BallTransform;
    }

    public void BallTransform()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (isBallPositionChanged == false)
            {
                isBallPositionChanged = true;
                transform.position = new Vector3(0, 5, -10);
            }
            else
            {
                isBallPositionChanged = false;
                transform.position = new Vector3(0, 0.5f, -10);
            }
        }
    }
}
