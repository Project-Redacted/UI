using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPage : MonoBehaviour
{
    public Transform Page;
    public float turnSpeed = 1f;
	private int defX = 90;
	private int defY = 180;

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
        Page.localRotation = Quaternion.Euler(defX, defY, 0);
        while (turned < 180)
        {
            Page.localRotation = Quaternion.Euler(defX, defY, turned * direction);
            turned += Time.deltaTime * turnSpeed;
            yield return null;
        }

        Page.localRotation = Quaternion.Euler(defX, defY, 0);
    }
}
