using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour
{
    public GameObject spider1;
    public GameObject spider2;

    public Animator anim;

    public Text youlose;

    public AudioSource happys;
    public AudioSource dies;
    public AudioSource scared;
    public AudioSource Lose;

    bool die;
    bool happy;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //happy.Stop();
        die = false;
        happy = false;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("scared",true);
        anim.SetBool("Happy", false);
        GameObject[] gos = GameObject.FindGameObjectsWithTag("Spider");
        if (gos.Length > 0 && !scared.isPlaying && gos.Length <= 20)
        {
            happy = false;
            happys.Stop();
            scared.Play();
            anim.SetBool("Happy", false);
        }
        if (gos.Length > 20 &&  !dies.isPlaying && !die)
        {
            dies.Play();
            Debug.Log("DIE");
            anim.SetBool("scared", false);
            anim.SetTrigger("die");
            StartCoroutine(lose());
            happys.Stop();
            scared.Stop();
            die = true;
            anim.SetBool("Happy", false);
        }
        if (gos.Length == 0 && !happys.isPlaying && !happy)
        {
            anim.SetBool("scared", false);
            anim.SetBool("Happy", true);
            happys.Play();
            scared.Stop();
            happy = true;
        }
    }

    IEnumerator lose()
    {
        yield return new WaitForSeconds(2f);
        Time.timeScale = 0;
        youlose.text = "YOU LOSE !";
        dies.Stop();
        Lose.Play();
        GameObject[] gos = GameObject.FindGameObjectsWithTag("Spider");

        foreach (GameObject go in gos)
        {
            go.GetComponent<BoxCollider>().enabled = false;
            
        }
    }
}
