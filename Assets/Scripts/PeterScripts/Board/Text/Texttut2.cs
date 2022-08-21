using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Texttut2 : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;

    public GameObject text3;
    public GameObject text4;
    public GameObject text44;

    public GameObject text5;
    public GameObject text6;

    public GameObject text7;
    public GameObject text8;
    public GameObject text9;
    public GameObject text10;
    public GameObject text11;

    public GameObject im1;
    public GameObject im2;
    public GameObject im3;
    public GameObject im4;
    public GameObject robot;
    public GameObject robot2;
    public GameObject robot3;
    public GameObject robot4;

    public GameObject dropphold;
    public GameObject mod;

    public float xing;
    public float zing;

    public bool drop;
    public Playertilemover player;

    // Start is called before the first frame update
    void Start()
    {
        drop = true;
    }

    // Update is called once per frame
    void Update()
    {


        if (text1.GetComponent<Textappear>().done == true && player.move == 2)
        {
            StartCoroutine("delay");

        }
        if (text2.GetComponent<Textappear>().done == true)
        {
            text3.SetActive(true);
        }
        if (text3.GetComponent<Textappear>().done == true)
        {
            im1.SetActive(true);

            text4.SetActive(true);
        }
        if (text4.GetComponent<Textappear>().done == true)
        {
            im2.SetActive(true);
            im3.SetActive(true);
            im4.SetActive(true);
        }
        if (robot!=null)
        {
            if (text4.GetComponent<Textappear>().done == true && robot.GetComponent<EnemyHealth>().health != 3)
            {
                text44.SetActive(true);
                im2.SetActive(false);
                im3.SetActive(false);
                im4.SetActive(false);
                im1.SetActive(false);
                text4.SetActive(false);
                text3.SetActive(false);
                text2.SetActive(false);


            }

        }
        if (text44.GetComponent<Textappear>().done == true && robot == null)
        {
            text5.SetActive(true);
            text44.SetActive(false);

            im2.SetActive(false);
            im3.SetActive(false);
            im4.SetActive(false);
            im1.SetActive(false);
            text4.SetActive(false);
            text3.SetActive(false);
            text2.SetActive(false);


        }
        if (robot2 == null)
        {
            text5.SetActive(false);

        }
        if (robot2 != null)
        {
            if (text5.GetComponent<Textappear>().done == true && robot2.GetComponent<EnemyLeftrightpatrol>().enabled == true)
            {
                text6.SetActive(true);
                text5.SetActive(false);

            }

        }
        if (text6.GetComponent<Textappear>().done == true && robot2 == null)
        {
            text6.SetActive(false);
            text7.SetActive(true);
        }
        if (robot3 == null||robot4 == null)
        {
            text7.SetActive(false);

        }
        if (robot3 != null)
        {
            if (text7.GetComponent<Textappear>().done == true && robot3.GetComponent<EnemyLeftrightpatrol>().enabled == true)
            {
                text7.SetActive(false);
                text8.SetActive(true);
            }

        }
        if (dropphold == null)
        {
            if (robot4 == null)
            {

                dropphold = robot3;
            }
            if (robot3 == null)
            {

                dropphold = robot4;

            }
        }

        if (robot4 == null || robot3 == null)
        {
            if (robot4 == null && robot3 == null)
            {

            }
            else
            {
                if(dropphold.transform.position.x > 0)
                {
                    xing = dropphold.transform.position.x;
                    zing = dropphold.transform.position.z;
                }

            }
        }
        if (text8.GetComponent<Textappear>().done == true)
        {
            if (robot4 == null || robot3 == null)
            {
                text8.SetActive(false);
                text9.SetActive(true);

            }
        }
        if (text9.GetComponent<Textappear>().done == true)
        {
            if (robot4 == null && robot3 == null)
            {
                if (drop == true)
                {
                    var newSquare = Instantiate(mod, new Vector3(xing, 1, zing), Quaternion.identity);
                    drop = false;

                }

                text9.SetActive(false);
                text10.SetActive(true);
                StartCoroutine("wait");

            }
        }
    }
    public IEnumerator delay()
    {
        yield return new WaitForSeconds(2f);

        text2.SetActive(true);
        text1.SetActive(false);


    }
    public IEnumerator wait()
    {

        yield return new WaitForSeconds(10);

        SceneManager.LoadScene("Tutorial 2.5");

    }
}
