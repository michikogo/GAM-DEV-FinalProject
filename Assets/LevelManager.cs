using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager
{
    private static LevelManager sharedInstance = null;
    private string currentScene = "Level1";
    private string MENU = "Level1";
    // Level 1 to 10
    private string LEVEL_ONE = "Level1";
    private string LEVEL_TWO = "Level2";
    private string LEVEL_THREE = "Level3";
    private string LEVEL_FOUR = "Level4";
    private string LEVEL_FIVE = "Level5";
    private string LEVEL_SIX = "Level6";
    private string LEVEL_SEVEN = "Level7";
    private string LEVEL_EIGHT = "Level8";
    private string LEVEL_NINE = "Level9";
    private string LEVEL_TEN = "Level10";
    // Level 11-20
    // Level 21-30
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
        if (this.currentScene == LEVEL_TWO)
        {
            this.currentScene = LEVEL_THREE;
        }
        if(this.currentScene == LEVEL_THREE)
        {
            this.currentScene = LEVEL_FOUR;
        }

        Debug.Log(this.currentScene);
        SceneManager.LoadScene(this.currentScene);
    }

    public void LoadGame()
    {
        this.currentScene = LEVEL_ONE;
        SceneManager.LoadScene(this.currentScene);
    }
}
