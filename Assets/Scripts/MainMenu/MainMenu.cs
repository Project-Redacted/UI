using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Maze size 25 by 25 tiles in size
    public void Play25()
    {
        Debug.Log("Load 25x25");
        SceneManager.LoadScene("25x25");
    }
    
    // Maze size 50 by 50 tiles in size
    public void play50()
    {
        Debug.Log("Load 50x50");
        SceneManager.LoadScene("50x50");
    }
    
    // Temporary maze size 100 by 100 tiles in size
    public void play100()
    {
        Debug.Log("Load 100x100");
        SceneManager.LoadScene("100x100");
    }
    
    // This wont work until the game has been built
    // But this will work
    public void QuitGame()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }

}
