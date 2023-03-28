using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class LoadSettings : MonoBehaviour
{
    // When scene loads, load settings from PlayerPrefs
    private void Start()
    {
        Settings.LoadSettings();
        
        // Set Motion Blur to On or Off
        var postVolume = Camera.main.GetComponent<PostProcessVolume>();
        var motionBlur = postVolume.profile.GetSetting<MotionBlur>();

        motionBlur.active = Settings.GraphicsMotionBlur == "On";
        Debug.Log("Motion Blur: " + motionBlur.active);

        // Set Fullscreen to On or Off
        Screen.fullScreen = Settings.GraphicsFullscreen == "On";
        Debug.Log("Fullscreen: " + Screen.fullScreen);
    }
}
