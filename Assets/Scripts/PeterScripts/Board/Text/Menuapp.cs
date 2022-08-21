using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menuapp : MonoBehaviour
{
    public bool stopped;
    public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
            if (stopped ==false)
            {
                stopped = true;
                Time.timeScale = 0.0f;
                menu.SetActive(true);
            }
            else
            {

                stopped = false;
                Time.timeScale = 1.0f;
                menu.SetActive(false);

            }
        }



    }
}
