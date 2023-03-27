using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MenuOptions : MonoBehaviour
{
    private void Start()
    {
        Settings.LoadSettings();
    }
    
    public void DisplaySettings()
    {
        Debug.Log("PlayerVolume: " + Settings.PlayerVolume);
    }
}
