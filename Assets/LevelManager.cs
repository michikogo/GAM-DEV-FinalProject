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
    private string LEVEL_TWELVE = "Level12";
    private string LEVEL_THIRTEEN = "Level13";
    private string LEVEL_FOURTEEN = "Level14";
    private string LEVEL_FIFTEEN = "Level15";
    private string LEVEL_SIXTEEN = "Level16";
    private string LEVEL_SEVENTEEN = "Level17";
    private string LEVEL_EIGHTEEN = "Level18";
    private string LEVEL_NINETEEN = "Level19";
    private string LEVEL_TWENTY = "Level20";
    // Winner
    private string WINNER = "Winner";

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
        else if (this.currentScene == LEVEL_ELEVEN)
            this.currentScene = LEVEL_TWELVE;
        else if (this.currentScene == LEVEL_TWELVE)
            this.currentScene = LEVEL_THIRTEEN;
        else if (this.currentScene == LEVEL_THIRTEEN)
            this.currentScene = LEVEL_FOURTEEN;
        else if (this.currentScene == LEVEL_FOURTEEN)
            this.currentScene = LEVEL_FIFTEEN;
        else if (this.currentScene == LEVEL_FIFTEEN)
            this.currentScene = LEVEL_SIXTEEN;
        else if (this.currentScene == LEVEL_SIXTEEN)
            this.currentScene = LEVEL_SEVENTEEN;
        else if (this.currentScene == LEVEL_SEVENTEEN)
            this.currentScene = LEVEL_EIGHTEEN;
        else if (this.currentScene == LEVEL_EIGHTEEN)
            this.currentScene = LEVEL_NINETEEN;
        else if (this.currentScene == LEVEL_NINETEEN)
            this.currentScene = LEVEL_TWENTY;
        // Winner
        else if (this.currentScene == LEVEL_TWENTY)
            this.currentScene = WINNER;

        Debug.Log(this.currentScene);
        SceneManager.LoadScene(this.currentScene);
    }

    public void LoadGame()
    {
        this.currentScene = LEVEL_ONE;
        SceneManager.LoadScene(this.currentScene);
    }
}
