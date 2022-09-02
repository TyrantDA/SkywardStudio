using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menusel2 : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;
    public Text text10;

    public bool sell1;
    public bool sell2;
    public bool sell3;
    public bool sell4;
    public bool sell5;
    public bool sell6;
    public bool sell7;
    public bool sell8;
    public bool sell9;
    public bool sell10;

    public bool stop;

    // Start is called before the first frame update
    void Start()
    {
        sell1 = true;
        sell2 = false;
        sell3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") == 0)
        {
            stop = false;
        }
        if (sell1 == true)
        {


            text1.color = Color.red;
            text2.color = Color.white;
            text3.color = Color.white;
            text4.color = Color.white;
            text5.color = Color.white;
            text6.color = Color.white;
            text7.color = Color.white;
            text8.color = Color.white;
            text9.color = Color.white;
            text10.color = Color.white;

            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {

                SceneManager.LoadScene("Tutorial 1");


            }

            if (Input.GetAxis("Vertical") == 1 && stop == false)
            {
                stop = true;
                sell1 = false;
                sell2 = false;
                sell3 = false;
                sell4 = false;
                sell5 = false;
                sell6 = false;
                sell7 = false;
                sell8 = false;
                sell9 = false;
                sell10 = true;

            }
            if (Input.GetAxis("Vertical") == -1 && stop == false)
            {
                stop = true;

                sell1 = false;
                sell2 = true;
                sell3 = false;
                sell4 = false;
                sell5 = false;
                sell6 = false;
                sell7 = false;
                sell8 = false;
                sell9 = false;
                sell10 = false;

            }

        }
        if (sell2 == true)
        {


            text1.color = Color.white;
            text2.color = Color.red;
            text3.color = Color.white;
            text4.color = Color.white;
            text5.color = Color.white;
            text6.color = Color.white;
            text7.color = Color.white;
            text8.color = Color.white;
            text9.color = Color.white;
            text10.color = Color.white;

            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {

                SceneManager.LoadScene("Tutorial 2");


            }

            if (Input.GetAxis("Vertical") == 1 && stop == false)
            {
                stop = true;
                sell1 = true;
                sell2 = false;
                sell3 = false;
                sell4 = false;
                sell5 = false;
                sell6 = false;
                sell7 = false;
                sell8 = false;
                sell9 = false;
                sell10 = false;

            }
            if (Input.GetAxis("Vertical") == -1 && stop == false)
            {
                stop = true;

                sell1 = false;
                sell2 = false;
                sell3 = true;
                sell4 = false;
                sell5 = false;
                sell6 = false;
                sell7 = false;
                sell8 = false;
                sell9 = false;
                sell10 = false;

            }

        }
        if (sell3 == true)
        {


            text1.color = Color.white;
            text2.color = Color.white;
            text3.color = Color.red;
            text4.color = Color.white;
            text5.color = Color.white;
            text6.color = Color.white;
            text7.color = Color.white;
            text8.color = Color.white;
            text9.color = Color.white;
            text10.color = Color.white;

            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {

                SceneManager.LoadScene("Tutorial 2.5");


            }

            if (Input.GetAxis("Vertical") == 1 && stop == false)
            {
                stop = true;
                sell1 = false;
                sell2 = true;
                sell3 = false;
                sell4 = false;
                sell5 = false;
                sell6 = false;
                sell7 = false;
                sell8 = false;
                sell9 = false;
                sell10 = false;

            }
            if (Input.GetAxis("Vertical") == -1 && stop == false)
            {
                stop = true;

                sell1 = false;
                sell2 = false;
                sell3 = false;
                sell4 = true;
                sell5 = false;
                sell6 = false;
                sell7 = false;
                sell8 = false;
                sell9 = false;
                sell10 = false;

            }

        }
        if (sell4 == true)
        {


            text1.color = Color.white;
            text2.color = Color.white;
            text3.color = Color.white;
            text4.color = Color.red;
            text5.color = Color.white;
            text6.color = Color.white;
            text7.color = Color.white;
            text8.color = Color.white;
            text9.color = Color.white;
            text10.color = Color.white;

            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {


                SceneManager.LoadScene("Tutorial 3");

            }

            if (Input.GetAxis("Vertical") == 1 && stop == false)
            {
                stop = true;
                sell1 = false;
                sell2 = false;
                sell3 = true;
                sell4 = false;
                sell5 = false;
                sell6 = false;
                sell7 = false;
                sell8 = false;
                sell9 = false;
                sell10 = false;

            }
            if (Input.GetAxis("Vertical") == -1 && stop == false)
            {
                stop = true;

                sell1 = false;
                sell2 = false;
                sell3 = false;
                sell4 = false;
                sell5 = true;
                sell6 = false;
                sell7 = false;
                sell8 = false;
                sell9 = false;
                sell10 = false;

            }

        }
        if (sell5 == true)
        {


            text1.color = Color.white;
            text2.color = Color.white;
            text3.color = Color.white;
            text4.color = Color.white;
            text5.color = Color.red;
            text6.color = Color.white;
            text7.color = Color.white;
            text8.color = Color.white;
            text9.color = Color.white;
            text10.color = Color.white;

            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {

                SceneManager.LoadScene("Tutorial 3.2");


            }

            if (Input.GetAxis("Vertical") == 1 && stop == false)
            {
                stop = true;
                sell1 = false;
                sell2 = false;
                sell3 = false;
                sell4 = true;
                sell5 = false;
                sell6 = false;
                sell7 = false;
                sell8 = false;
                sell9 = false;
                sell10 = false;

            }
            if (Input.GetAxis("Vertical") == -1 && stop == false)
            {
                stop = true;

                sell1 = false;
                sell2 = false;
                sell3 = false;
                sell4 = false;
                sell5 = false;
                sell6 = true;
                sell7 = false;
                sell8 = false;
                sell9 = false;
                sell10 = false;

            }

        }
        if (sell6 == true)
        {


            text1.color = Color.white;
            text2.color = Color.white;
            text3.color = Color.white;
            text4.color = Color.white;
            text5.color = Color.white;
            text6.color = Color.red;
            text7.color = Color.white;
            text8.color = Color.white;
            text9.color = Color.white;
            text10.color = Color.white;

            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {

                SceneManager.LoadScene("Tutorial 4");


            }

            if (Input.GetAxis("Vertical") == 1 && stop == false)
            {
                stop = true;
                sell1 = false;
                sell2 = false;
                sell3 = false;
                sell4 = false;
                sell5 = true;
                sell6 = false;
                sell7 = false;
                sell8 = false;
                sell9 = false;
                sell10 = false;

            }
            if (Input.GetAxis("Vertical") == -1 && stop == false)
            {
                stop = true;

                sell1 = false;
                sell2 = false;
                sell3 = false;
                sell4 = false;
                sell5 = false;
                sell6 = false;
                sell7 = true;
                sell8 = false;
                sell9 = false;
                sell10 = false;

            }

        }
        if (sell7 == true)
        {


            text1.color = Color.white;
            text2.color = Color.white;
            text3.color = Color.white;
            text4.color = Color.white;
            text5.color = Color.white;
            text6.color = Color.white;
            text7.color = Color.red;
            text8.color = Color.white;
            text9.color = Color.white;
            text10.color = Color.white;

            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                SceneManager.LoadScene("Tutorial 4.8");



            }

            if (Input.GetAxis("Vertical") == 1 && stop == false)
            {
                stop = true;
                sell1 = false;
                sell2 = false;
                sell3 = false;
                sell4 = false;
                sell5 = false;
                sell6 = true;
                sell7 = false;
                sell8 = false;
                sell9 = false;
                sell10 = false;

            }
            if (Input.GetAxis("Vertical") == -1 && stop == false)
            {
                stop = true;

                sell1 = false;
                sell2 = false;
                sell3 = false;
                sell4 = false;
                sell5 = false;
                sell6 = false;
                sell7 = false;
                sell8 = true;
                sell9 = false;
                sell10 = false;

            }

        }
        if (sell8 == true)
        {


            text1.color = Color.white;
            text2.color = Color.white;
            text3.color = Color.white;
            text4.color = Color.white;
            text5.color = Color.white;
            text6.color = Color.white;
            text7.color = Color.white;
            text8.color = Color.red;
            text9.color = Color.white;
            text10.color = Color.white;

            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {

                SceneManager.LoadScene("Tutorial 5");


            }

            if (Input.GetAxis("Vertical") == 1 && stop == false)
            {
                stop = true;
                sell1 = false;
                sell2 = false;
                sell3 = false;
                sell4 = false;
                sell5 = false;
                sell6 = false;
                sell7 = true;
                sell8 = false;
                sell9 = false;
                sell10 = false;

            }
            if (Input.GetAxis("Vertical") == -1 && stop == false)
            {
                stop = true;

                sell1 = false;
                sell2 = false;
                sell3 = false;
                sell4 = false;
                sell5 = false;
                sell6 = false;
                sell7 = false;
                sell8 = false;
                sell9 = true;
                sell10 = false;

            }

        }
        if (sell9 == true)
        {


            text1.color = Color.white;
            text2.color = Color.white;
            text3.color = Color.white;
            text4.color = Color.white;
            text5.color = Color.white;
            text6.color = Color.white;
            text7.color = Color.white;
            text8.color = Color.white;
            text9.color = Color.red;
            text10.color = Color.white;

            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {


                SceneManager.LoadScene("Tutorial 6.2");

            }

            if (Input.GetAxis("Vertical") == 1 && stop == false)
            {
                stop = true;
                sell1 = false;
                sell2 = false;
                sell3 = false;
                sell4 = false;
                sell5 = false;
                sell6 = false;
                sell7 = false;
                sell8 = true;
                sell9 = false;
                sell10 = false;

            }
            if (Input.GetAxis("Vertical") == -1 && stop == false)
            {
                stop = true;

                sell1 = false;
                sell2 = false;
                sell3 = false;
                sell4 = false;
                sell5 = false;
                sell6 = false;
                sell7 = false;
                sell8 = false;
                sell9 = false;
                sell10 = true;

            }

        }
        if (sell10 == true)
        {


            text1.color = Color.white;
            text2.color = Color.white;
            text3.color = Color.white;
            text4.color = Color.white;
            text5.color = Color.white;
            text6.color = Color.white;
            text7.color = Color.white;
            text8.color = Color.white;
            text9.color = Color.white;
            text10.color = Color.red;

            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {


                Application.Quit();

            }

            if (Input.GetAxis("Vertical") == 1 && stop == false)
            {
                stop = true;
                sell1 = false;
                sell2 = false;
                sell3 = false;
                sell4 = false;
                sell5 = false;
                sell6 = false;
                sell7 = false;
                sell8 = false;
                sell9 = true;
                sell10 = false;

            }
            if (Input.GetAxis("Vertical") == -1 && stop == false)
            {
                stop = true;

                sell1 = true;
                sell2 = false;
                sell3 = false;
                sell4 = false;
                sell5 = false;
                sell6 = false;
                sell7 = false;
                sell8 = false;
                sell9 = false;
                sell10 = false;

            }

        }
    }
}
