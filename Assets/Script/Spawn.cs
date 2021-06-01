using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spider;
    public float minTime, maxTime;
    public float minPos, maxPos;
    public float minPos1, maxPos1;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(SpiderSpawn());
    }
    private void OnEnable()
    {
        StartCoroutine(SpiderSpawn());
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpiderSpawn()
    {

        GameObject go = Instantiate(spider, transform.position + (Vector3.right * Random.Range(minPos, maxPos)) + (Vector3.forward * Random.Range(minPos1, maxPos1)), Quaternion.identity);
        go.transform.parent = GameObject.Find("ImageTarget").transform;
        yield return new WaitForSeconds(Random.Range(minTime, maxTime));
        StartCoroutine(SpiderSpawn());
    }
}
