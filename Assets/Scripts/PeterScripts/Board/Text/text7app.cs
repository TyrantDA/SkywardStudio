using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class text7app : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (text1.GetComponent<Textappear>().done == true)
        {
            text2.SetActive(true);


        }
        if (text2.GetComponent<Textappear>().done == true)
        {
            text3.SetActive(true);
            text4.SetActive(true);


        }
        if (text3.GetComponent<Textnum3>().num == 0)
        {
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(true);
            StartCoroutine("wait");


        }
    }
    public IEnumerator wait()
    {

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("Tutorial 5");

    }
}
