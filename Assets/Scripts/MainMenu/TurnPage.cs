using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPage : MonoBehaviour
{
    
    public Transform Page;
    public float turnSpeed = 1f;
    private int turnDirection = 1;
    private bool isTurning = false;
    
    public void turnLeft()
    {
        StopAllCoroutines();
        StartCoroutine(FlipPage(1));
    }
    
    public void turnRight()
    { 
        StopAllCoroutines();
        StartCoroutine(FlipPage(-1));
    }

    IEnumerator FlipPage(int direction)
    {
        float turned = 0;
        Page.localRotation = Quaternion.Euler(0, 0, 0);
        while (turned < 180)
        {
            Page.localRotation = Quaternion.Euler(0, turned * direction, 0);
            turned += Time.deltaTime * turnSpeed;
            yield return null;
        }

        Page.localRotation = Quaternion.Euler(0, 0, 0);
    }
}
