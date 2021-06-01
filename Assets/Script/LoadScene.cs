using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    //public GameObject arcamera;
    //public GameObject camera1;
    public GameObject loadingScreen;
    public Slider loadingslider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playgame()
    {
        StartCoroutine(Loadscene("Game"));
    }
    public void menu()
    {
        StartCoroutine(Loadscene("Menu"));
    }

    public void exit()
    {
        Application.Quit();
    }

    public void restart()
    {
        //arcamera.SetActive(false);
        //camera1.SetActive(true);
        StartCoroutine(Loadscene("Game"));
    }

    IEnumerator Loadscene(string scenename)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(scenename);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            loadingslider.value = progress;

            yield return null;
        }

    }
}
