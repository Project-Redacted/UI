using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public static int PlayerVolume = 60;
    
    public static string PlayerForwards = "W";
    public static string PlayerBackwards = "S";
    public static string PlayerLeft = "A";
    public static string PlayerRight = "D";
    public static string PlayerJump = "Space";
    public static string PlayerSneak = "CTRL";
    public static string PlayerRun = "Shift";
    public static string ItemPickup = "F";
    public static string ItemDrop = "G";
    public static string ItemUse = "E";
    public static string GamePause = "ESC";
    
    public static float CameraFOV = 69;
    public static float CameraMouseX = 1;
    public static float CameraMouseY = 1;
    
    public static string GraphicsMotionBlur = "On";
    public static string GraphicsWorldFog = "Off";
    public static int GraphicsResolution = 1;
    public static string GraphicsFullscreen = "On";
    
    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("volume", PlayerVolume);
        
        PlayerPrefs.SetString("playerForwards", PlayerForwards);
        PlayerPrefs.SetString("playerBackwards", PlayerBackwards);
        PlayerPrefs.SetString("playerLeft", PlayerLeft);
        PlayerPrefs.SetString("playerRight", PlayerRight);
        PlayerPrefs.SetString("playerJump", PlayerJump);
        PlayerPrefs.SetString("playerSneak", PlayerSneak);
        PlayerPrefs.SetString("playerRun", PlayerRun);
        PlayerPrefs.SetString("itemPickup", ItemPickup);
        PlayerPrefs.SetString("itemDrop", ItemDrop);
        PlayerPrefs.SetString("itemUse", ItemUse);
        PlayerPrefs.SetString("gamePause", GamePause);
        
        PlayerPrefs.SetFloat("cameraFOV", CameraFOV);
        PlayerPrefs.SetFloat("cameraMouseX", CameraMouseX);
        PlayerPrefs.SetFloat("cameraMouseY", CameraMouseY);
        
        PlayerPrefs.SetString("graphicsMotionBlur", GraphicsMotionBlur);
        PlayerPrefs.SetString("graphicsWorldFog", GraphicsWorldFog);
        PlayerPrefs.SetInt("graphicsResolution", GraphicsResolution);
        PlayerPrefs.SetString("graphicsFullscreen", GraphicsFullscreen);
    }

    public static void LoadSettings()
    {   
        if (PlayerPrefs.HasKey("volume"))
        {
            PlayerVolume = PlayerPrefs.GetInt("volume");
        }
        if (PlayerPrefs.HasKey("playerForwards"))
        {
            PlayerForwards = PlayerPrefs.GetString("playerForwards");
        }
        if (PlayerPrefs.HasKey("playerBackwards"))
        {
            PlayerBackwards = PlayerPrefs.GetString("playerBackwards");
        }
        if (PlayerPrefs.HasKey("playerLeft"))
        {
            PlayerLeft = PlayerPrefs.GetString("playerLeft");
        }
        if (PlayerPrefs.HasKey("playerRight"))
        {
            PlayerRight = PlayerPrefs.GetString("playerRight");
        }
        if (PlayerPrefs.HasKey("playerJump"))
        {
            PlayerJump = PlayerPrefs.GetString("playerJump");
        }
        if (PlayerPrefs.HasKey("playerSneak"))
        {
            PlayerSneak = PlayerPrefs.GetString("playerSneak");
        }
        if (PlayerPrefs.HasKey("playerRun"))
        {
            PlayerRun = PlayerPrefs.GetString("playerRun");
        }
        if (PlayerPrefs.HasKey("itemPickup"))
        {
            ItemPickup = PlayerPrefs.GetString("itemPickup");
        }
        if (PlayerPrefs.HasKey("itemDrop"))
        {
            ItemDrop = PlayerPrefs.GetString("itemDrop");
        }
        if (PlayerPrefs.HasKey("itemUse"))
        {
            ItemUse = PlayerPrefs.GetString("itemUse");
        }
        if (PlayerPrefs.HasKey("gamePause"))
        {
            GamePause = PlayerPrefs.GetString("gamePause");
        }
        if (PlayerPrefs.HasKey("cameraFOV"))
        {
            CameraFOV = PlayerPrefs.GetFloat("cameraFOV");
        }
        if (PlayerPrefs.HasKey("cameraMouseX"))
        {
            CameraMouseX = PlayerPrefs.GetFloat("cameraMouseX");
        }
        if (PlayerPrefs.HasKey("cameraMouseY"))
        {
            CameraMouseY = PlayerPrefs.GetFloat("cameraMouseY");
        }
        if (PlayerPrefs.HasKey("graphicsMotionBlur"))
        {
            GraphicsMotionBlur = PlayerPrefs.GetString("graphicsMotionBlur");
        }
        if (PlayerPrefs.HasKey("graphicsWorldFog"))
        {
            GraphicsWorldFog = PlayerPrefs.GetString("graphicsWorldFog");
        }
        if (PlayerPrefs.HasKey("graphicsResolution"))
        {
            GraphicsResolution = PlayerPrefs.GetInt("graphicsResolution");
        }
        if (PlayerPrefs.HasKey("graphicsFullscreen"))
        {
            GraphicsFullscreen = PlayerPrefs.GetString("graphicsFullscreen");
        }
    }
}
