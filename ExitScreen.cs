using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public Button exitButton;
    // Update is called once per frame
    void Start()
    {
        exitButton = GetComponent<Button>();
        exitButton.onClick.AddListener(quit);
    }
    public void quit()
    {
        Application.Quit();
    }
}
