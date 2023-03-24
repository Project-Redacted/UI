using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MenuOptions : MonoBehaviour
{
    private Settings gameData;
    void Start()
    {
        gameData = new Settings();
        gameData.Load();
    }
    
    public void DisplaySettings()
    {
        // Display the current settings
        Debug.Log(gameData.Data.volume);
        Debug.Log(gameData.Data.cameraOptions["cameraSensitivity"]);
        Debug.Log(gameData.Data.graphicsOptions["graphicsQuality"]);
    }
}
