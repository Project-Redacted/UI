using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPage : MonoBehaviour
{
    
    public GameObject Page;
    public float turnSpeed = 1f;
    private int turnDirection = 1;
    private bool isTurning = false;
    
    private void turnLeft()
    {
        if (isTurning)
        {
            return;
        }
        isTurning = true;
        turnDirection = -1;
    }
    
    private void turnRight()
    {
        if (isTurning)
        {
            return;
        }
        isTurning = true;
        turnDirection = 1;
    }
    
    void Update()
    {
        if (isTurning)
        {
            // Rotate the page to -180 degrees if turnDirection is -1 and 0 degrees if turnDirection is 1
            Page.transform.rotation = Quaternion.Lerp(Page.transform.rotation, Quaternion.Euler(0, turnDirection * 180, 0), turnSpeed * Time.deltaTime);
            // If the page has rotated to -180 degrees or 0 degrees, stop rotating
            if (Page.transform.rotation == Quaternion.Euler(0, turnDirection * 180, 0))
            {
                isTurning = false;
            }
        }
    }
}
