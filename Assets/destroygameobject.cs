using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroygameobject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(destroythis());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator destroythis()
    {
        yield return new WaitForSeconds(2.5f);
        Destroy(this.gameObject);
    }
}
