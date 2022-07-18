using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcheck : MonoBehaviour
{
    public Camramover cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cam.moved == true)
        {
            StartCoroutine("delay");
        }
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(2);
        this.gameObject.SetActive(false);
    }
}
