using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomePage : MonoBehaviour {

    public SceneFader sceneFader;
    public string leveltoLoad = "HomePage";

    public void Play()
    {
        sceneFader.fadeTo(leveltoLoad);
    }

    public void LevelSelect()
    {
        sceneFader.fadeTo(leveltoLoad);
    }
}
