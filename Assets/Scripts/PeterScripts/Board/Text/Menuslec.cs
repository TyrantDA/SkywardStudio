using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class Menuslec : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;

    public bool sell1;
    public bool sell2;
    public bool sell3;
    public Menuapp hold;

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
            sell2 = false;
            sell3 = false;
            text1.color = Color.red;
            text2.color = Color.white;
            text3.color = Color.white;
            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                hold.stopped = false;
                Time.timeScale = 1.0f;
                hold.menu.SetActive(false);


            }

            if (Input.GetAxis("Vertical") == 1&& stop==false)
            {
                stop = true;
                sell3 = true;
                sell2 = false;
                sell1 = false;
            }
            if (Input.GetAxis("Vertical") == -1 && stop == false)
            {
                stop = true;

                sell2 = true;
                sell3 = false;
                sell1 = false;
            }

        }
        if (sell2 == true)
        {
            sell1 = false;
            sell3 = false;
            text1.color = Color.white;
            text2.color = Color.red;
            text3.color = Color.white;
            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                Time.timeScale = 1.0f;
                SceneManager.LoadScene("Comabtmenue");



            }
            if (Input.GetAxis("Vertical") == 1 && stop == false)
            {
                stop = true;

                sell1 = true;
                sell2 = false;
                sell3 = false;
            }
            if (Input.GetAxis("Vertical") == -1 && stop == false)
            {
                stop = true;

                sell3 = true;
                sell2 = false;
                sell1 = false;
            }

        }
        if (sell3 == true)
        {
            sell2 = false;
            sell1 = false;
            text1.color = Color.white;
            text2.color = Color.white;
            text3.color = Color.red;
            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                Time.timeScale = 1.0f;

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);



            }
            if (Input.GetAxis("Vertical") == 1 && stop == false)
            {
                stop = true;

                sell2 = true;
                sell3 = false;
                sell1 = false;
            }
            if (Input.GetAxis("Vertical") == -1 && stop == false)
            {
                stop = true;

                sell1 = true;
                sell2 = false;
                sell3 = false;
            }

        }
    }
}
