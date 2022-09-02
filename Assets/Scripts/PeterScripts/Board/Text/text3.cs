using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class text3 : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;

    public GameObject text30;
    public GameObject text4;

    public GameObject text5;
    public GameObject text6;
    public GameObject text33;

    public GameObject text7;
    public GameObject text8;
    public GameObject text9;
    public GameObject text10;
    public GameObject text11;
    public GameObject im1;
    public GameObject im2;
    public Playertilemover player;
    public GameObject en1;
    public GameObject en2;

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
            text30.SetActive(true);
        }
        if (text30.GetComponent<Textappear>().done == true)
        {
            text4.SetActive(true);
        }
        if (text4.GetComponent<Textappear>().done == true)
        {
            player.enabled = true;

            text5.SetActive(true);
        }
        if ( en1 != null)
        {
            if (text5.GetComponent<Textappear>().done == true && en1.GetComponent<Rangedattackmove>().pop == true && en1 != null)
            {
                text5.SetActive(false);
                text4.SetActive(false);
                text30.SetActive(false);
                text2.SetActive(false);
                text1.SetActive(false);
                text6.SetActive(true);

            }

        }
        if (en1 == null)
        {
            text6.SetActive(false);

            text5.SetActive(false);
            text4.SetActive(false);
            text30.SetActive(false);
            text2.SetActive(false);
            text1.SetActive(false);
        }
        if (en1 != null)
        {
            if (text6.GetComponent<Textappear>().done == true && en1.GetComponent<Rangedattackmove>().pop2 == true && en1 != null)
            {
                text7.SetActive(true);

                text6.SetActive(false);

            }

        }

        if (text7.GetComponent<Textappear>().done == true)
        {
            im1.SetActive(true);

            text33.SetActive(true);
        }
        if (text33.GetComponent<Textappear>().done == true)
        {
            im1.SetActive(true);
            im2.SetActive(true);

            text8.SetActive(true);
        }
        if (en1 == null && text8.GetComponent<Textappear>().done == true)
        {
            text6.SetActive(false);
            text7.SetActive(false);
            text8.SetActive(false);
            im1.SetActive(false);
            im2.SetActive(false);
            text33.SetActive(false);


            text9.SetActive(true);

        }

        if (en2 == null )
        {
            text9.SetActive(false);

            text10.SetActive(true);
            StartCoroutine("wait");


        }
    }
    public IEnumerator wait()
    {

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("Tutorial 3");

    }
}
