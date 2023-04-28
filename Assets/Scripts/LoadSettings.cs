using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using TMPro;
using UnityEngine.UI;

public class LoadSettings : MonoBehaviour
{
    // Set UI elements
    public Slider UIVolume;
    
    public TMP_InputField UIForwards;
    public TMP_InputField UIBackwards;
    public TMP_InputField UILeft;
    public TMP_InputField UIRight;
    public TMP_InputField UIJump;
    public TMP_InputField UISneak;
    public TMP_InputField UIRun;
    public TMP_InputField UIItemPickup;
    public TMP_InputField UIItemDrop;
    public TMP_InputField UIItemUse;
    public TMP_InputField UIGamePause;
    public Slider UICameraMouseX;
    public Slider UICameraMouseY;
    
    public Slider UICameraFOV;
    public TMP_Dropdown UIResolution;
    public Toggle UIFullscreen;
    
    public Toggle UIMotionBlur;
    public Toggle UIWorldFog;

    void Awake()
    {
        // Set default values
        int settingVolume = PlayerPrefs.HasKey("volume") ? PlayerPrefs.GetInt("volume") : 60;
        
        string settingForwards = PlayerPrefs.HasKey("playerForwards") ? PlayerPrefs.GetString("playerForwards") : "W";
        string settingBackwards = PlayerPrefs.HasKey("playerBackwards") ? PlayerPrefs.GetString("playerBackwards") : "S";
        string settingLeft = PlayerPrefs.HasKey("playerLeft") ? PlayerPrefs.GetString("playerLeft") : "A";
        string settingRight = PlayerPrefs.HasKey("playerRight") ? PlayerPrefs.GetString("playerRight") : "D";
        string settingJump = PlayerPrefs.HasKey("playerJump") ? PlayerPrefs.GetString("playerJump") : "Space";
        string settingSneak = PlayerPrefs.HasKey("playerSneak") ? PlayerPrefs.GetString("playerSneak") : "Ctrl";
        string settingRun = PlayerPrefs.HasKey("playerRun") ? PlayerPrefs.GetString("playerRun") : "Shift";
        string settingItemPickup = PlayerPrefs.HasKey("itemPickup") ? PlayerPrefs.GetString("itemPickup") : "F";
        string settingItemDrop = PlayerPrefs.HasKey("itemDrop") ? PlayerPrefs.GetString("itemDrop") : "G";
        string settingItemUse = PlayerPrefs.HasKey("itemUse") ? PlayerPrefs.GetString("itemUse") : "E";
        string settingGamePause = PlayerPrefs.HasKey("gamePause") ? PlayerPrefs.GetString("gamePause") : "Escape";
        float settingCameraMouseX = PlayerPrefs.HasKey("cameraMouseX") ? PlayerPrefs.GetFloat("cameraMouseX") : 1;
        float settingCameraMouseY = PlayerPrefs.HasKey("cameraMouseY") ? PlayerPrefs.GetFloat("cameraMouseY") : 1;
        
        float settingCameraFOV = PlayerPrefs.HasKey("cameraFOV") ? PlayerPrefs.GetFloat("cameraFOV") : 90;
        int settingGraphicsResolution = PlayerPrefs.HasKey("graphicsResolution") ? PlayerPrefs.GetInt("graphicsResolution") : 0;
        int settingGraphicsFullscreen = PlayerPrefs.HasKey("graphicsFullscreen") ? PlayerPrefs.GetInt("graphicsFullscreen") : 1;
        
        int settingGraphicsMotionBlur = PlayerPrefs.HasKey("graphicsMotionBlur") ? PlayerPrefs.GetInt("graphicsMotionBlur") : 1;
        int settingGraphicsWorldFog = PlayerPrefs.HasKey("graphicsWorldFog") ? PlayerPrefs.GetInt("graphicsWorldFog") : 0;

        // Set UI elements
        // Set volume
        UIVolume.value = settingVolume;
        AudioListener.volume = settingVolume / 100f;

        // Set FOV
        UICameraFOV.value = settingCameraFOV;

        // Set available resolutions in dropdown, set current resolution
        UIResolution.ClearOptions();
        List<string> options = new List<string>();
        foreach (var resolution in Screen.resolutions)
        {
            options.Add(resolution.width + "x" + resolution.height);
        }
        UIResolution.AddOptions(options);
        UIResolution.value = settingGraphicsResolution;
        
        // Set fullscreen
        if (settingGraphicsFullscreen == 1)
        {
            UIFullscreen.isOn = true;
            Screen.fullScreen = true;
        }
        else
        {
            UIFullscreen.isOn = false;
            Screen.fullScreen = false;
        }
        
        // Set motion blur
        UIMotionBlur.isOn = settingGraphicsMotionBlur == 1;
        UIWorldFog.isOn = settingGraphicsWorldFog == 1;
    }
}
