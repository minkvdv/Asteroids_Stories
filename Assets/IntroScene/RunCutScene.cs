using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class IntroCutscene : MonoBehaviour
{
    private float waitTime = 3f;

    public Animator fadeAnimator;
    public GameObject shot1;
    public GameObject shot2;
    public GameObject shot3;

    public Animator asteroidAnimator;
    public Animator alienAnimator;

    private void Start()
    {
        StartCoroutine(RunCutscene());
    }

    private IEnumerator RunCutscene()
    {
        // --- SHOT 1 ---
        shot1.SetActive(true);

        fadeAnimator.Play("FadeIn");   // fade from black
        yield return new WaitForSeconds(1f);  // fade duration

        yield return new WaitForSeconds(2f); // how long shot 1 stays visible


        // --- CHANGE TO SHOT 2 ---
        fadeAnimator.Play("FadeOut");
        yield return new WaitForSeconds(1f);  // fade duration

        shot1.SetActive(false);
        shot2.SetActive(true);

        fadeAnimator.Play("FadeIn");
        yield return new WaitForSeconds(1f); // fade duration

        asteroidAnimator.Play("AsteroidFlyIn");
        yield return new WaitForSeconds(1f); // shot 2 visible time


        // --- CHANGE TO SHOT 3 ---
        fadeAnimator.Play("FadeOut");
        yield return new WaitForSeconds(1f);

        shot2.SetActive(false);
        shot3.SetActive(true);

        fadeAnimator.Play("FadeIn");
        yield return new WaitForSeconds(1f);

        yield return new WaitForSeconds(1f);

     
        // --- FINAL FADE TO GAME ---
        fadeAnimator.Play("FadeOut");
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(1);
    }
}
