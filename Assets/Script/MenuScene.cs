using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScene : MonoBehaviour
{
    public Text Highscoretext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Highscoretext.text = "HighScore : " + PlayerPrefs.GetInt("HighScore").ToString();
    }

    public void resethighscore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
    }
}
