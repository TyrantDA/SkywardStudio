using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Text4sc : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;

    public GameObject text30;
    public GameObject text4;

    public GameObject text5;
    public GameObject text6;
    public GameObject hint1;
    public GameObject hint1im;

    public GameObject hint2;
    public GameObject hint2im;

    public textnum numleft;
    public textnum numleft2;

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
            text30.SetActive(true);
            text4.SetActive(true);
            text5.SetActive(true);

        }
        if (text5.GetComponent<Textappear>().done == true)
        {
            hint1.SetActive(true);
        }
        if (hint1.GetComponent<Textappear>().done == true)
        {
            hint1im.SetActive(true);
            hint2.SetActive(true);

        }
        if (hint2.GetComponent<Textappear>().done == true)
        {
            hint2im.SetActive(true);
        }

        if (numleft.num == 0 && numleft2.num == 0)
        {
            text1.SetActive(false);

            text2.SetActive(false);
            text30.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(false);
            text6.SetActive(true);
            hint2im.SetActive(false);
            hint1im.SetActive(false);
            hint2.SetActive(false);
            hint1.SetActive(false);
            StartCoroutine("wait");


        }
    }
    public IEnumerator wait()
    {

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("Tutorial 3.2");

    }
}
