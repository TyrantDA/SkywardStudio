using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inventroyMenu : MonoBehaviour
{
    bool paused = false;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void resume()
    {
        paused = false;
        Time.timeScale = 1f;
        menu.SetActive(false);
    }

    public void QuitTOMenu()
    {
        paused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("start");
    }


    private void SetCursorState(bool newState)
    {
        Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
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
                SetCursorState(false);
            }
            else
            {
                paused = false;
                Time.timeScale = 1f;
                menu.SetActive(false);
                SetCursorState(true);
            }
        }
    }
}
