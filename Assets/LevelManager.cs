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
    // Level 21-30
    private string LEVEL_TWENTYONE = "Level21";
    private string LEVEL_TWENTYTWO = "Level22";
    private string LEVEL_TWENTYTHREE = "Level23";
    private string LEVEL_TWENTYFOUR = "Level24";
    private string LEVEL_TWENTYFIVE = "Level25";
    private string LEVEL_TWENTYSIX = "Level26";
    private string LEVEL_TWENTYSEVEN = "Level27";
    private string LEVEL_TWENTYEIGHT = "Level28";
    private string LEVEL_TWENTYNINE = "Level29";
    private string LEVEL_THIRTY = "Level30";

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

        // Level 1-10
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
        if(this.currentScene == LEVEL_FOUR)
        {
            this.currentScene = LEVEL_FIVE;
        }
        if(this.currentScene == LEVEL_FIVE)
        {
            this.currentScene = LEVEL_SIX;
        }
        if (this.currentScene == LEVEL_SIX)
        {
            this.currentScene = LEVEL_SEVEN;
        }
        if(this.currentScene == LEVEL_SEVEN)
        {
            this.currentScene = LEVEL_EIGHT;
        }
        if (this.currentScene == LEVEL_EIGHT)
        {
            this.currentScene = LEVEL_NINE;
        }
        if(this.currentScene == LEVEL_NINE)
        {
            this.currentScene = LEVEL_TEN;
        }
        // Level 11-20
        if (this.currentScene == LEVEL_TEN)
            this.currentScene = LEVEL_ELEVEN;
        if (this.currentScene == LEVEL_ELEVEN)
            this.currentScene = LEVEL_TWELVE;
        if (this.currentScene == LEVEL_TWELVE)
            this.currentScene = LEVEL_THIRTEEN;
        if (this.currentScene == LEVEL_THIRTEEN)
            this.currentScene = LEVEL_FOURTEEN;
        if (this.currentScene == LEVEL_FOURTEEN)
            this.currentScene = LEVEL_FIFTEEN;
        if (this.currentScene = LEVEL_FIFTEEN)
            this.currentScene = LEVEL_SIXTEEN;
        if (this.currentScene == LEVEL_SIXTEEN)
            this.currentScene = LEVEL_SEVENTEEN;
        if (this.currentScene = LEVEL_SEVENTEEN)
            this.currentScene = LEVEL_EIGHTEEN;
        if (this.currentScene = LEVEL_EIGHTEEN)
            this.currentScene = LEVEL_NINETEEN;
        if (this.currentScene == LEVEL_NINETEEN)
            this.currentScene = LEVEL_TWENTY;
        // Level 21-30
        if (this.currentScene == LEVEL_TWENTY)
            this.currentScene = LEVEL_TWENTYONE;
        if (this.currentScene == LEVEL_TWENTYONE)
            this.currentScene = LEVEL_TWENTYTWO;
        if (this.currentScene == LEVEL_TWENTYTWO)
            this.currentScene = LEVEL_TWENTYTHREE;
        if (this.currentScene == LEVEL_TWENTYTHREE)
            this.currentScene = LEVEL_TWENTYFOUR;
        if (this.currentScene == LEVEL_TWENTYFOUR)
            this.currentScene = LEVEL_TWENTYFIVE;
        if (this.currentScene == LEVEL_TWENTYFIVE)
            this.currentScene = LEVEL_TWENTYSIX;
        if (this.currentScene == LEVEL_TWENTYSIX)
            this.currentScene = LEVEL_TWENTYSEVEN;
        if (this.currentScene == LEVEL_TWENTYSEVEN)
            this.currentScene = LEVEL_TWENTYEIGHT;
        if (this.currentScene == LEVEL_TWENTYEIGHT)
            this.currentScene = LEVEL_TWENTYNINE;
        if (this.currentScene == LEVEL_TWENTYNINE)
            this.currentScene = LEVEL_THIRTY;

        Debug.Log(this.currentScene);
        SceneManager.LoadScene(this.currentScene);
    }

    public void LoadGame()
    {
        this.currentScene = LEVEL_ONE;
        SceneManager.LoadScene(this.currentScene);
    }
}
