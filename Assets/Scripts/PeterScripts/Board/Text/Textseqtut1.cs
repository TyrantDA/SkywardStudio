using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Textseqtut1 : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;

    public GameObject text3;
    public GameObject text4;

    public GameObject text5;
    public GameObject text6;

    public GameObject text7;
    public GameObject text8;


    public GameObject joystick1;
    public GameObject joystick15;

    public GameObject joystick2;

    public Playertilemover player;
    public tut1attack enemy;
    public Camramover cam;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {


        if (text2.GetComponent<Textappear>().done == true)
        {
            joystick1.SetActive(true);
        }
        if (joystick1.GetComponent<Textappear>().done == true)
        {
            joystick15.SetActive(true);
        }
        if (player.move > 2 && joystick1.GetComponent<Textappear>().done == true)
        {
            text1.SetActive(true);
        }

        if(cam.moved == false && text1.GetComponent<Textappear>().done == true)
        {
            joystick2.SetActive(true);

        }

        if (enemy.attacked == true)
        {
            text1.SetActive(false);
            joystick1.SetActive(false);
            joystick15.SetActive(false);

            joystick2.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(true);

        }
        if (text3.GetComponent<Textappear>().done == true)
        {
            text4.SetActive(true);
        }
        if (text4.GetComponent<Textappear>().done == true && enemy.fuel <= 20)
        {
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(true);
        }
        if (text5.GetComponent<Textappear>().done == true && enemy.fuel <= 10)
        {
            text5.SetActive(false);
            text6.SetActive(true);
        }
        if (text6.GetComponent<Textappear>().done == true && enemy.fuel <= 0)
        {
            text6.SetActive(false);
            text7.SetActive(true);
        }
        if (text7.GetComponent<Textappear>().done == true)
        {
            text8.SetActive(true);
            StartCoroutine("wait");
        }
    }
    public IEnumerator wait()
    {
        yield return new WaitForSeconds(10);

        SceneManager.LoadScene("Tutorial 2");

    }


}
