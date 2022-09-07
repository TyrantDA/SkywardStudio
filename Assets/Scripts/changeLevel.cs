using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeLevel : MonoBehaviour
{
    public string level;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void SetCursorState(bool newState)
    {
        Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    // Update is called once per frame
    public void ButtonPress()
    {
        SetCursorState(true);
        SceneManager.LoadScene(level);
    }
}
