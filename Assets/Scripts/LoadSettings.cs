using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using TMPro;
using UnityEngine.UI;

public class LoadSettings : MonoBehaviour
{
    public static int SettingVolume = 60;
    public static string SettingForwards = "W";
    public static string SettingBackwards = "S";
    public static string SettingLeft = "A";
    public static string SettingRight = "D";
    public static string SettingJump = "Space";
    public static string SettingSneak = "CTRL";
    public static string SettingRun = "Shift";
    public static string SettingItemPickup = "F";
    public static string SettingItemDrop = "G";
    public static string SettingItemUse = "E";
    public static string SettingGamePause = "ESC";
    public static float SettingCameraFOV = 90;
    public static float SettingCameraMouseX = 1;
    public static float SettingCameraMouseY = 1;
    public static int SettingGraphicsMotionBlur = 1;
    public static int SettingGraphicsWorldFog = 0;
    public static int SettingGraphicsResolution = 0;
    public static int SettingGraphicsFullscreen = 0;
    
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
    public Slider UICameraFOV;
    public Slider UICameraMouseX;
    public Slider UICameraMouseY;
    public Toggle UIMotionBlur;
    public Toggle UIWorldFog;
    public TMP_Dropdown UIResolution;
    public Toggle UIFullscreen;

    void Start()
    {   
        // Genuinely the worst code I have ever written
        if (PlayerPrefs.HasKey("volume")) { SettingVolume = PlayerPrefs.GetInt("volume"); }
        
        if (PlayerPrefs.HasKey("playerForwards")) { SettingForwards = PlayerPrefs.GetString("playerForwards"); }
        if (PlayerPrefs.HasKey("playerBackwards")) { SettingBackwards = PlayerPrefs.GetString("playerBackwards"); }
        if (PlayerPrefs.HasKey("playerLeft")) { SettingLeft = PlayerPrefs.GetString("playerLeft"); }
        if (PlayerPrefs.HasKey("playerRight")) { SettingRight = PlayerPrefs.GetString("playerRight"); }
        if (PlayerPrefs.HasKey("playerJump")) { SettingJump = PlayerPrefs.GetString("playerJump"); }
        if (PlayerPrefs.HasKey("playerSneak")) { SettingSneak = PlayerPrefs.GetString("playerSneak"); }
        if (PlayerPrefs.HasKey("playerRun")) { SettingRun = PlayerPrefs.GetString("playerRun"); }
        if (PlayerPrefs.HasKey("itemPickup")) { SettingItemPickup = PlayerPrefs.GetString("itemPickup"); }
        if (PlayerPrefs.HasKey("itemDrop")) { SettingItemDrop = PlayerPrefs.GetString("itemDrop"); }
        if (PlayerPrefs.HasKey("itemUse")) { SettingItemUse = PlayerPrefs.GetString("itemUse"); }
        if (PlayerPrefs.HasKey("gamePause")) { SettingGamePause = PlayerPrefs.GetString("gamePause"); }
        
        if (PlayerPrefs.HasKey("cameraFOV")) { SettingCameraFOV = PlayerPrefs.GetFloat("cameraFOV"); }
        if (PlayerPrefs.HasKey("cameraMouseX")) { SettingCameraMouseX = PlayerPrefs.GetFloat("cameraMouseX"); }
        if (PlayerPrefs.HasKey("cameraMouseY")) { SettingCameraMouseY = PlayerPrefs.GetFloat("cameraMouseY"); }
        if (PlayerPrefs.HasKey("graphicsMotionBlur")) { SettingGraphicsMotionBlur = PlayerPrefs.GetInt("graphicsMotionBlur"); }
        if (PlayerPrefs.HasKey("graphicsWorldFog")) { SettingGraphicsWorldFog = PlayerPrefs.GetInt("graphicsWorldFog"); }

        if (PlayerPrefs.HasKey("graphicsResolution")) { SettingGraphicsResolution = PlayerPrefs.GetInt("graphicsResolution"); }

        if (PlayerPrefs.HasKey("graphicsFullscreen")) { SettingGraphicsFullscreen = PlayerPrefs.GetInt("graphicsFullscreen"); }
        
        
        // Set volume
        UIVolume.value = SettingVolume;
        AudioListener.volume = SettingVolume / 100f;
        
        // Set available resolutions in dropdown, set current resolution
        UIResolution.ClearOptions();
        List<string> options = new List<string>();
        foreach (var resolution in Screen.resolutions)
        {
            options.Add(resolution.width + "x" + resolution.height);
        }
        UIResolution.AddOptions(options);
        UIResolution.value = SettingGraphicsResolution;
        
        // Set fullscreen
        if (SettingGraphicsFullscreen == 1)
        {
            UIFullscreen.isOn = true;
            Screen.fullScreen = true;
        }
        else
        {
            UIFullscreen.isOn = false;
            Screen.fullScreen = false;
        }
    }
}
