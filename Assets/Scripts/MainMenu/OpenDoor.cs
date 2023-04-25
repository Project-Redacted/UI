using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Transform Door;
    public float turnSpeed = 1f;
    private int defX = -90;
    private int defY = 0;
    
    public int openRotation = 170;
    public int closedRotation = 90;

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
        float turned = closedRotation;
        Door.localRotation = Quaternion.Euler(defX, defY, closedRotation);
        while (turned < openRotation)
        {
            Door.localRotation = Quaternion.Euler(defX, defY, turned * 1);
            turned += Time.deltaTime * turnSpeed;
            yield return null;
        }

        Door.localRotation = Quaternion.Euler(defX, defY, openRotation);
    }
    
    IEnumerator FlipClosed()
    {
        float turned = openRotation;
        Door.localRotation = Quaternion.Euler(defX, defY, openRotation);
        while (closedRotation < turned)
        {
            Door.localRotation = Quaternion.Euler(defX, defY, turned * 1);
            turned -= Time.deltaTime * turnSpeed;
            yield return null;
        }

        Door.localRotation = Quaternion.Euler(defX, defY, closedRotation);
    }
}
