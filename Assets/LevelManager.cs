using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager
{
    private static LevelManager sharedInstance = null;
    private string currentScene = "Level1";
    //private string MENU = "SceneMenu";
    // Level 1-10
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
    // Emission
    private string LEVEL_ELEVEN = "Level11";

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

        if (this.currentScene == LEVEL_ONE)
            this.currentScene = LEVEL_ONE;

        if (this.currentScene == LEVEL_ONE)
            this.currentScene = LEVEL_TWO;
        else if (this.currentScene == LEVEL_TWO)
            this.currentScene = LEVEL_THREE;
        else if (this.currentScene == LEVEL_THREE)
            this.currentScene = LEVEL_FOUR;
        else if (this.currentScene == LEVEL_FOUR)
            this.currentScene = LEVEL_FIVE;
        else if (this.currentScene == LEVEL_FIVE)
            this.currentScene = LEVEL_SIX;
        else if (this.currentScene == LEVEL_SIX)
            this.currentScene = LEVEL_SEVEN;
        else if (this.currentScene == LEVEL_SEVEN)
            this.currentScene = LEVEL_EIGHT;
        else if (this.currentScene == LEVEL_EIGHT)
            this.currentScene = LEVEL_NINE;
        else if (this.currentScene == LEVEL_NINE)
            this.currentScene = LEVEL_TEN;
        // Emission
        else if (this.currentScene == LEVEL_TEN)
            this.currentScene = LEVEL_ELEVEN;

        Debug.Log(this.currentScene);
        SceneManager.LoadScene(this.currentScene);
    }

    public void LoadGame()
    {
        this.currentScene = LEVEL_ONE;
        SceneManager.LoadScene(this.currentScene);
    }
}
