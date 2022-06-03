using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventroyMenu : MonoBehaviour
{
    bool paused = false;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!paused)
            {
                paused = true;
                Time.timeScale = 0f;
                menu.SetActive(true);
            }
            else
            {
                paused = false;
                Time.timeScale = 1f;
                menu.SetActive(false);
            }
        }
    }
}
