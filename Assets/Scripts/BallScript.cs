using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private bool isBallPositionChanged;

    private void Start()
    {
        isBallPositionChanged = false;
    }

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
        if(Input.GetKey(KeyCode.Keypad1))
        {
            if (isBallPositionChanged == false)
            {
                transform.position = new Vector3(0, 5, -10);
                isBallPositionChanged = true;
            }
            else
            {
                transform.position = new Vector3(0, 0.5f, -10);
                isBallPositionChanged = false;
            }
        }
    }
}
