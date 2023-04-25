using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Transform Door;
    public float turnSpeed = 1f;
    private int defX = -90;
    private int defY = 0;

    public void openDoor()
    {
        StopAllCoroutines();
        StartCoroutine(FlipOpen());
    }

    public void closeDoor()
    { 
        StopAllCoroutines();
        StartCoroutine(FlipClosed());
    }

    IEnumerator FlipOpen()
    {
        float turned = 90;
        Door.localRotation = Quaternion.Euler(defX, defY, 90);
        while (turned < 116)
        {
            Door.localRotation = Quaternion.Euler(defX, defY, turned * 1);
            turned += Time.deltaTime * turnSpeed;
            yield return null;
        }

        Door.localRotation = Quaternion.Euler(defX, defY, 116);
    }
    
    IEnumerator FlipClosed()
    {
        float turned = 116;
        Door.localRotation = Quaternion.Euler(defX, defY, 116);
        while (90 < turned)
        {
            Door.localRotation = Quaternion.Euler(defX, defY, turned * 1);
            turned -= Time.deltaTime * turnSpeed;
            yield return null;
        }

        Door.localRotation = Quaternion.Euler(defX, defY, 90);
    }
}
