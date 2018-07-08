using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishButton : MonoBehaviour {

    public SceneFader sceneFader;
   
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LevelSelect()
    {
        sceneFader.fadeTo("LevelSelect");
    }
}
