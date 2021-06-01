using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Score : MonoBehaviour
{
    int score;

    public Animator anim;

    public GameObject blood;

    public AudioSource splash;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getScore()
    {
        score = PlayerPrefs.GetInt("Score");
        anim.SetTrigger("die");

        GameObject go = Instantiate(blood, transform.position, Quaternion.identity);
        go.transform.parent = GameObject.Find("ImageTarget").transform;

        PlayerPrefs.SetInt("Score", score+10);
        Debug.Log(PlayerPrefs.GetInt("Score"));

        splash.Play();
    }
}
