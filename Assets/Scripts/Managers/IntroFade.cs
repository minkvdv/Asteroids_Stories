using UnityEngine;
using System.Collections;

public class IntroFade : MonoBehaviour
{
    public Animator fadeAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fadeAnimator.Play("FadeIn");
    }

    
}
