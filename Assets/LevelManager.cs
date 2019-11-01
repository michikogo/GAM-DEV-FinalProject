using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager
{
    private static LevelManager sharedInstance = null;
    private string currentScene = "Level1";
    private string MENU = "Level1";
    private string LEVEL_ONE = "Level1";
    private string LEVEL_TWO = "Level2";

    private LevelManager()
    {

    }

    public static LevelManager Instance
    {
        get
        {
            return sharedInstance;
        }
    }

    public static void Initialize()
    {
        if (sharedInstance == null)
        {
            sharedInstance = new LevelManager();
        }

    }

    public void loadLevel()
    {
        // this.currentScene = sceneName;
        // SceneManager.LoadScene(this.currentScene);
        if(this.currentScene == MENU)
        {
            this.currentScene = LEVEL_ONE;
        }
        if (this.currentScene == LEVEL_ONE)
        {
            this.currentScene = LEVEL_TWO;
        }
        //else if (this.currentScene == LEVEL_TWO)
        //{
        //    this.currentScene = LEVEL_ONE;
        //}
        Debug.Log(this.currentScene);

        SceneManager.LoadScene(this.currentScene);
    }

    public void LoadGame()
    {
        this.currentScene = LEVEL_ONE;
        SceneManager.LoadScene(this.currentScene);
    }
}
