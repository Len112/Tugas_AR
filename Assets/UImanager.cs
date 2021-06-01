using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UImanager : MonoBehaviour
{
    public Text scoretext;
    public Text highscoretext;

    public GameObject arcamera;
    public GameObject camera1;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("Score", 0);
        highscoretext.text = "HighScore : " + PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "SCORE : " + PlayerPrefs.GetInt("Score").ToString();
        if (PlayerPrefs.GetInt("HighScore") < PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score"));
            highscoretext.text = "HighScore : " + PlayerPrefs.GetInt("HighScore").ToString();
        }
    }

    public void restart()
    {
        arcamera.SetActive(false);
        camera1.SetActive(true);
        SceneManager.LoadScene("Game");
    }
}
