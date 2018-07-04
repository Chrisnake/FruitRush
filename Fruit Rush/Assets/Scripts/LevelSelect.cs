using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour 
{
    public SceneFader sceneFader;
    public string leveltoLoad;
   
    public void Select(string levelName)
    {
        sceneFader.fadeTo(levelName);
    }

	public void Back()
    {
        sceneFader.fadeTo(leveltoLoad);
    }
}
