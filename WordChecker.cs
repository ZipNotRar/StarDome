using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordChecker : MonoBehaviour
{
    public Text wordTextbox;
    public Text AttrTextbox;
    public Button wordCheck;
    public ScriptableString1 value;
    public ScriptableString1 value2;
    public Text ScoreTextbox;
    public int wordAttriScore = 5;
    public int wordScoreInitial = 0;
    public int totalScore = 10;

    // Start is called before the first frame update
    void Start()
    {
        wordCheck.GetComponent<Button>();
        wordCheck.onClick.AddListener(guessWord);
        wordTextbox.GetComponent<Text>();
        AttrTextbox.GetComponent<Text>();
        ScoreTextbox.GetComponent<Text>();
        ScoreTextbox.text = wordScoreInitial.ToString();

    }
    // Update is called once per frame
    void guessWord()
    {
        if (wordTextbox.text == value.Value)
        {
            wordTextbox.color = Color.green;
            AttrTextbox.color = Color.red;
            ScoreTextbox.text = wordAttriScore.ToString();
            Debug.Log("You have guessed it correctly for word");
        }
        else
        {
            Debug.Log("Wrong answer. Please try again for word");
        }
        if (AttrTextbox.text == value2.Value)
        {
            AttrTextbox.color = Color.green;
            wordTextbox.color = Color.red;
            ScoreTextbox.text = wordAttriScore.ToString();
            Debug.Log("You have guessed it correctly for Attribute");
        }
        else
        {
            Debug.Log("Wrong answer. Please try again");
        }
        if (wordTextbox.text == value.Value && AttrTextbox.text == value2.Value)
        {
            AttrTextbox.color = Color.green;
            wordTextbox.color = Color.green;
            ScoreTextbox.text = totalScore.ToString();
        }
        else
        {
            AttrTextbox.color = Color.red;
            wordTextbox.color = Color.red;
        }
    }
}