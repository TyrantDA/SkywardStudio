using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Text8app : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;

    public GameObject text6;
    public Playertilemover player;
    public GameObject im1;

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
            player.dashtrue = true;

        }
        if (text2.GetComponent<Textappear>().done == true)
        {
            im1.SetActive(true);

            text3.SetActive(true);

        }
        if (text3.GetComponent<Textappear>().done == true)

        {
            text5.SetActive(true);

            text4.SetActive(true);

        }
        if (player.move>=17)

        {
            text6.SetActive(true);

            text5.SetActive(false);
            im1.SetActive(false);

            text4.SetActive(false);
            text3.SetActive(false);
            text2.SetActive(false);
            text1.SetActive(false);

            StartCoroutine("wait");

        }
    }
    public IEnumerator wait()
    {

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("Tutorial 6.2");

    }
}
