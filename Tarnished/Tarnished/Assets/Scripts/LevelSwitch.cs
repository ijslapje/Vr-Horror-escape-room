using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSwitch : MonoBehaviour
{
    public int currLevel = 0;
    public string[] levelNames = new string[2] { "Menu", "Isolation Cell" };


    static LevelSwitch s = null;

    // Start is called before the first frame update
    void Start()
    {
        if(s == null)
        {
            s = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void Startgame()
    {
        currLevel = (currLevel + 1) % 2;
        Valve.VR.SteamVR_LoadLevel.Begin(levelNames[currLevel]);
        DestroyScriptInstance();
    }

    void DestroyScriptInstance()
    {
        // Removes this script instance from the game object
        Destroy(this);
    }

}
