using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour
{
    // A bool that checks and see if the ball gameobject has changed position or not
    private bool isCapsuleScaleChanged;

    // Start is called before the first frame update
    private void Start()
    {
        isCapsuleScaleChanged = false;
    }

    // Update is called once per frame
    private void Update()
    {
        CapsuleTransform();
    }

    private void OnEnable()
    {
        Actions.OnBallEvent += CapsuleTransform;
    }

    private void OnDisable()
    {
        Actions.OnBallEvent -= CapsuleTransform;
    }

    public void CapsuleTransform()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (isCapsuleScaleChanged == false)
            {
                isCapsuleScaleChanged = true;
            }
            else
            {
                isCapsuleScaleChanged = false;
            }
        }
    }
}
