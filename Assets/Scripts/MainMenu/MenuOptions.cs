using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOptions : MonoBehaviour
{
    public void DisplaySettings()
    {
        Debug.Log("PlayerVolume: " + Settings.PlayerVolume);
    }
}
