using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour 
{
    public Image image;
    public AnimationCurve fadeCurve;

    void Start()
    {
        StartCoroutine(fadeIn());
    }

    public void fadeTo(string scene)
    {
        StartCoroutine(fadeOut(scene));
    }

    IEnumerator fadeIn()
    {
        float t = 0.5f;
        while (t > 0) //Keep animating until the time reaches 0
        {
            t -= Time.deltaTime;
            float alpha = fadeCurve.Evaluate(t); //Evaluates the alpha of the transition using the animationcurve
            image.color = new Color(0f, 0f, 0f, alpha); //Black colour
            yield return 0; //This means skip the next frame
        }
    }

    IEnumerator fadeOut(string scene)
    {
        float t = 0f;
        while (t < 0.8f) //Keep animating until the time reaches 0
        {
            t += Time.deltaTime;
            float alpha = fadeCurve.Evaluate(t); //Evaluates the alpha of the transition using the animationcurve
            image.color = new Color(0f, 0f, 0f, alpha); //Black colour
            yield return 0; //This means skip the next frame
        }
        SceneManager.LoadScene(scene);
    }
}
