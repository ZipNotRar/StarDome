using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadeIn : MonoBehaviour
{
    public Image buttonFadeIn;
    public Dropdown wordA;
    // Start is called before the first frame update
    void Start()
    {
        buttonFadeIn.canvasRenderer.SetAlpha(0.0f);
        if (wordA.isActiveAndEnabled)
        {
            fadeIn();
        }
    }

    void fadeIn()
    {
        buttonFadeIn.CrossFadeAlpha(1, 4, false);
    }
}